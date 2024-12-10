using System.Configuration;
namespace InvenTech
{
    internal static class Program
    {
        // Formlar� tutan Stack
        public static Stack<Form> formHistory = new Stack<Form>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            formHistory.Push(loginForm); // Login formunu stack'e ekle
            Application.Run(loginForm);
        }

        // Bir formdan ba�ka bir forma ge�erken �a�r�lacak metot
        public static void NavigateTo(Form newForm)
        {
            // E�er Stack'te bir form varsa, en �stteki formu kapat
            if (formHistory.Count > 0)
            {
                Form currentForm = formHistory.Peek(); // Stack'teki mevcut formu al
                currentForm.Hide(); // Mevcut formu gizle
                newForm.Owner = currentForm; // Yeni formun sahipli�ini belirle
            }

            formHistory.Push(newForm); // Yeni formu stack'e ekle
            newForm.Show(); // Yeni formu g�ster
        }

        // Geri d�n�� butonuna t�kland���nda �a�r�lacak metot
        public static void GoBack()
        {
            if (formHistory.Count > 1) // Stack'te en az 2 form varsa
            {
                Form currentForm = formHistory.Pop(); // Mevcut formu stack'ten ��kar
                currentForm.Close(); // Mevcut formu kapat
                Form previousForm = formHistory.Peek(); // �nceki formu al
                previousForm.Show(); // �nceki formu g�ster
            }
        }
    }
}