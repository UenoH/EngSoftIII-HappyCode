using System.Windows.Forms;

namespace HappyCode.Management.Core.Util
{
    public class Msg
    {
        public static void Alert(string Message)
        {
            MessageBox.Show(Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Alert(string Message, string Header)
        {
            MessageBox.Show(Message, Header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Info(string Message)
        {
            MessageBox.Show(Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Info(string Message, string Header)
        {
            MessageBox.Show(Message, Header, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool Question(string Message)
        {
            return MessageBox.Show(Message, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static bool Question(string Message, string Header)
        {
            return MessageBox.Show(Message, Header, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
