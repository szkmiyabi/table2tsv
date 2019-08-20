using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace table2tsv
{
    public partial class Form1 : Form
    {

        private string prefix = "<!doctype html><html lang='ja'><head><meta charset='utf-8'></head><body>";
        private string sufix = "</body></html>";

        //コンストラクタ
        public Form1()
        {
            InitializeComponent();
            preview_default();

            //デフォルトでチェックON
            ampCodeStripCheck.Checked = true;
            doTagStripCheck.Checked = true;
            aTagHrefCheck.Checked = true;
            doBrReplaceCheck.Checked = true;
        }

        //デフォルト表示に戻す
        private void preview_default()
        {
            browserControl.DocumentText = prefix + "<p style='margin-top:30px;text-align:center;'>ここにプレビューが表示される</p>" + sufix;
        }

        //TSVファイル保存先を取得
        private string _get_tsv_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "TSVファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //TSV行データの生成
        private string _edit_row_tsv(List<object> row)
        {
            string row_str = "";
            for (int j = 0; j < row.Count; j++)
            {
                row_str += (string)row[j];
                if (j < (row.Count - 1)) row_str += "\t";
            }
            row_str += "\r\n";
            return row_str;
        }

        //テキスト整形
        private string _text_clean(string str)
        {
            if(ampCodeStripCheck.Checked == true) {
                try { str = Regex.Replace(str, @"&nbsp;", ""); } catch (Exception ex) { }
                try { str = Regex.Replace(str, @"&amp;", "&"); } catch (Exception ex) { }
            }
            if (doBrReplaceCheck.Checked == true) {
                try { str = Regex.Replace(str, @"<br>", "｜", RegexOptions.IgnoreCase); } catch (Exception ex) { }
            }

            if (doTagStripCheck.Checked == true) {
                try { str = Regex.Replace(str, @"<\/*.+?>", ""); } catch (Exception ex) { }
            }
            return str;
        }

        //aタグ判定
        private Boolean _is_a_tag(string str)
        {
            if (str == null || str == "") return false;
            Regex pt = new Regex(@"</*a.+?>", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str)) return true;
            else return false;
        }

        //href抽出
        private string _get_href_attr(string str)
        {
            string ret = "";
            Regex pt = new Regex(@"(href="")(.+?)("")", RegexOptions.IgnoreCase);
            if (pt.IsMatch(str))
            {
                MatchCollection mc = pt.Matches(str);
                Match mt = mc[0];
                ret = mt.Groups[2].Value;
            }
            return ret;
        }


        //tableタグをパースする
        private List<object> get_table_data_for_list()
        {
            List<object> arr = new List<object>();
            HtmlDocument d = browserControl.Document;
            HtmlElementCollection tbls = d.GetElementsByTagName("table");
            foreach(HtmlElement tbl in tbls)
            {
                HtmlElementCollection trs = tbl.GetElementsByTagName("tr");
                int i = 0;
                foreach (HtmlElement tr in trs)
                {
                    if (i > 0)
                    {
                        List<object> cols = new List<object>();
                        HtmlElementCollection tds = tr.GetElementsByTagName("td");
                        foreach (HtmlElement td in tds)
                        {
                            string td_val = (string)td.InnerHtml;
                            string cl_td_val = _text_clean(td_val);
                            cols.Add(cl_td_val);
                            if (_is_a_tag(td_val) == true && aTagHrefCheck.Checked == true)
                            {
                                string href = _get_href_attr(td_val);
                                if(doAddRootPrefixCheck.Checked == true && rootUrlText.Text != "")
                                {
                                    href = rootUrlText.Text + href;
                                }
                                try { href = Regex.Replace(href, @"&amp;", "&"); } catch (Exception ex) { }
                                cols.Add(href);
                            }
                        }
                        arr.Add(cols);
                    }
                    i++;
                }
            }
            return arr;
        }


        //DOM構築
        private void domStructButton_Click(object sender, EventArgs e)
        {
            if (inputText.Text == "") return;
            string body = inputText.Text;
            browserControl.DocumentText = prefix + body + sufix;
        }

        //TSV保存
        private void saveTSVButton_Click(object sender, EventArgs e)
        {
            string save_path = _get_tsv_save_path();

            //BOM無し設定
            System.Text.Encoding enc = new System.Text.UTF8Encoding(false);
            StreamWriter sw = new StreamWriter(save_path, false, enc);

            string body = "";
            List<object> arr = get_table_data_for_list();
            for (int i = 0; i < arr.Count; i++)
            {
                List<object> row =(List<object>)arr[i];
                string row_str = _edit_row_tsv(row);
                sw.Write(row_str);
            }

            sw.Close();
            MessageBox.Show("処理が完了しました!");

        }

        //リセット
        private void domResetButton_Click(object sender, EventArgs e)
        {
            inputText.Clear();
            preview_default();
        }
    }
}
