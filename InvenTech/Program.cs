using System.Configuration;
namespace InvenTech
{
    internal static class Program
    {
        // Formlarý tutan Stack
        public static Stack<Form> formHistory = new Stack<Form>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            LoginForm loginForm = new LoginForm();
            formHistory.Push(loginForm); // Login formunu stack'e ekle
            Application.Run(loginForm);
        }

        // Bir formdan baþka bir forma geçerken çaðrýlacak metot
        public static void NavigateTo(Form newForm)
        {
            // Eðer Stack'te bir form varsa, en üstteki formu kapat
            if (formHistory.Count > 0)
            {
                Form currentForm = formHistory.Peek(); // Stack'teki mevcut formu al
                currentForm.Hide(); // Mevcut formu gizle
                newForm.Owner = currentForm; // Yeni formun sahipliðini belirle
            }

            formHistory.Push(newForm); // Yeni formu stack'e ekle
            newForm.Show(); // Yeni formu göster
        }

        // Geri dönüþ butonuna týklandýðýnda çaðrýlacak metot
        public static void GoBack()
        {
            if (formHistory.Count > 1) // Stack'te en az 2 form varsa
            {
                Form currentForm = formHistory.Pop(); // Mevcut formu stack'ten çýkar
                currentForm.Close(); // Mevcut formu kapat
                Form previousForm = formHistory.Peek(); // Önceki formu al
                previousForm.Show(); // Önceki formu göster
            }
        }
    }
}