using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HappyCode.Management.Core.Util
{
    public class ControlTreat
    {
        #region Methods
        public static void OnlyNumberKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)127 || e.KeyChar == (char)8))
                e.Handled = true;
        }
        public static void OnlyDecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)127 || e.KeyChar == (char)8 || e.KeyChar == (char)44) || (e.KeyChar == (char)44 && (sender as Control).Text.Contains((char)44)))
                e.Handled = true;
        }
        public static void MaskTextChanged(object sender, EventArgs e)
        {
            if (sender != null && sender is TextBox)
            {
                var TextBox = ((TextBox)sender);
                string txOnlyNumbers = RemoveNonNumbers(TextBox.Text);
                switch (TextBox.Name.ToUpper().Replace("TXT", string.Empty))
                {
                    case "CNPJ":
                        switch (txOnlyNumbers.Length)
                        {
                            case 2: TextBox.Text = string.Format(@"{0:00}", long.Parse(txOnlyNumbers)); break;
                            case 3: TextBox.Text = string.Format(@"{0:00\.0}", long.Parse(txOnlyNumbers)); break;
                            case 5: TextBox.Text = string.Format(@"{0:00\.000}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:00\.000\.0}", long.Parse(txOnlyNumbers)); break;
                            case 8: TextBox.Text = string.Format(@"{0:00\.000\.000}", long.Parse(txOnlyNumbers)); break;
                            case 9: TextBox.Text = string.Format(@"{0:00\.000\.000\/0}", long.Parse(txOnlyNumbers)); break;
                            case 12: TextBox.Text = string.Format(@"{0:00\.000\.000\/0000}", long.Parse(txOnlyNumbers)); break;
                            case 13: TextBox.Text = string.Format(@"{0:00\.000\.000\/0000\-0}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                    case "INSCRICAOESTADUAL":
                        switch (txOnlyNumbers.Length)
                        {
                            case 3: TextBox.Text = string.Format(@"{0:000}", long.Parse(txOnlyNumbers)); break;
                            case 4: TextBox.Text = string.Format(@"{0:000\.0}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:000\.000}", long.Parse(txOnlyNumbers)); break;
                            case 7: TextBox.Text = string.Format(@"{0:000\.000\.0}", long.Parse(txOnlyNumbers)); break;
                            case 9: TextBox.Text = string.Format(@"{0:000\.000\.000}", long.Parse(txOnlyNumbers)); break;
                            case 10: TextBox.Text = string.Format(@"{0:000\.000\.000\.0}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                    case "CPF":
                        switch (txOnlyNumbers.Length)
                        {
                            case 3: TextBox.Text = string.Format(@"{0:000}", long.Parse(txOnlyNumbers)); break;
                            case 4: TextBox.Text = string.Format(@"{0:000\.0}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:000\.000}", long.Parse(txOnlyNumbers)); break;
                            case 7: TextBox.Text = string.Format(@"{0:000\.000\.0}", long.Parse(txOnlyNumbers)); break;
                            case 9: TextBox.Text = string.Format(@"{0:000\.000\.000}", long.Parse(txOnlyNumbers)); break;
                            case 10: TextBox.Text = string.Format(@"{0:000\.000\.000\-0}", long.Parse(txOnlyNumbers)); break;
                            case 11: TextBox.Text = string.Format(@"{0:000\.000\.000\-00}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                    case "CEP":
                        switch (txOnlyNumbers.Length)
                        {
                            case 5: TextBox.Text = string.Format(@"{0:00000}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:00000\-0}", long.Parse(txOnlyNumbers)); break;
                            case 7: TextBox.Text = string.Format(@"{0:00000\-00}", long.Parse(txOnlyNumbers)); break;
                            case 8: TextBox.Text = string.Format(@"{0:00000\-000}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                    case "TELEFONE":
                        switch (txOnlyNumbers.Length)
                        {
                            //case 2: TextBox.Text = string.Format(@"{0:00}", long.Parse(txOnlyNumbers)); break;
                            //case 3: TextBox.Text = string.Format(@"{0:\(00\)0}", long.Parse(txOnlyNumbers)); break;
                            //case 6: TextBox.Text = string.Format(@"{0:\(00\)0000}", long.Parse(txOnlyNumbers)); break;
                            case 5: TextBox.Text = string.Format(@"{0:0000\-0}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:0000\-00}", long.Parse(txOnlyNumbers)); break;
                            case 7: TextBox.Text = string.Format(@"{0:0000\-000}", long.Parse(txOnlyNumbers)); break;
                            case 8: TextBox.Text = string.Format(@"{0:0000\-0000}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                    case "CELULAR":
                        switch (txOnlyNumbers.Length)
                        {
                            //case 2: TextBox.Text = string.Format(@"{0:00}", long.Parse(txOnlyNumbers)); break;
                            //case 3: TextBox.Text = string.Format(@"{0:\(00\)0}", long.Parse(txOnlyNumbers)); break;
                            //case 7: TextBox.Text = string.Format(@"{0:\(00\)00000}", long.Parse(txOnlyNumbers)); break;
                            case 6: TextBox.Text = string.Format(@"{0:00000\-0}", long.Parse(txOnlyNumbers)); break;
                            case 7: TextBox.Text = string.Format(@"{0:00000\-00}", long.Parse(txOnlyNumbers)); break;
                            case 8: TextBox.Text = string.Format(@"{0:00000\-000}", long.Parse(txOnlyNumbers)); break;
                            case 9: TextBox.Text = string.Format(@"{0:00000\-0000}", long.Parse(txOnlyNumbers)); break;
                        }
                        break;
                }
                TextBox.Select(TextBox.TextLength, TextBox.TextLength);
            }
        }
        public static string RemoveNonNumbers(string str)
        {
            return new string(str.Where(x => char.IsNumber(x)).ToArray());
        }
        public static bool IsValid(object sender)
        {
            bool isValid = false;
            if (sender != null && sender is TextBox)
            {
                var TextBox = ((TextBox)sender);
                isValid = !string.IsNullOrWhiteSpace(TextBox.Text) || TextBox.Tag == null || TextBox.Tag.ToString() == string.Empty;
                TextBox.BackColor = isValid ? Color.White : Color.FromArgb(255, 106, 111);
            }
            return isValid;
        }
        #endregion
    }
}
