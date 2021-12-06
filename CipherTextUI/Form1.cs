using CipherTextLibrary;

namespace CipherTextUI
{
    public partial class TextCipher : Form
    {
        public TextCipher()
        {
            InitializeComponent();
        }

        // decipher our text on click
        private void btnDecipher_Click(object sender, EventArgs e)
        {
            textTranslate.Text = Translator.GetDecipherText(textAccept.Text, Translator.Morse);
        }

        // cipher our text on click
        private void btnCipher_Click(object sender, EventArgs e)
        {
            textTranslate.Text = Translator.GetCipherText(textAccept.Text, Translator.Morse);
        }

        // clear all text in program
        private void btnClear_Click(object sender, EventArgs e)
        {
            textAccept.Text = String.Empty;
            textTranslate.Text = String.Empty;
        }
    }
}