namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random _random = new Random();
        static string upperCaseList = "QWERTYUIOPASDFGHJKLÑZXCVBNM";
        static string lowerCaseList = "qwertyuiopasdfghjklñzxcvbnm";
        static string numericList = "0123456789";
        static string symbolsList = "!@#$%^&*()[]=<>/,.";

        string allCharsList = string.Empty;
        public Form1()
        {
            InitializeComponent();
            txtPasswordLength.Text = "20";
        }

        private void BuildCharsList()
        {

            allCharsList = String.Empty;

            if (chkIncludesLowerCase.Checked)
                allCharsList += lowerCaseList;
            if (chkIncludesUppercase.Checked)
                allCharsList += upperCaseList;
            if (chkIncludesNumbers.Checked)
                allCharsList += numericList;
            if (chkIncludesSymbols.Checked)
                allCharsList += symbolsList;

            if (string.IsNullOrEmpty(allCharsList))
                allCharsList = lowerCaseList + upperCaseList + numericList + symbolsList;

        }

        private string GeneratePassword(int length)
        {
            string newPassword = string.Empty;
            if (length < 6)
                throw new Exception("A strong password needs to have more than 6 characters");

            for (int i = 0; i < length; i++)
            {
                newPassword += GetRandomChar();
            }

            return newPassword;
        }

        private string GetRandomChar()
        {
            return allCharsList.ToCharArray()[(int)Math.Floor(_random.NextDouble() * allCharsList.Length)].ToString();

        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                BuildCharsList();
                txtNewPassword.Text = GeneratePassword(int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

           

        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}