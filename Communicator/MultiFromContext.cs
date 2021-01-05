using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicator
{
    public class MultiFormContext : ApplicationContext
    {
        private int openForms;
        public MultiFormContext(params Form[] forms)
        {
            openForms = forms.Length;

            foreach (var form in forms)
            {
                form.FormClosed += (s, args) =>
                {
                    if (Interlocked.Decrement(ref openForms) == 0)
                        ExitThread();
                        
                    if (openForms == 0 || openForms == 1)
                    {
                        Application.ExitThread();
                    }
                };

                form.Show();
            }
        }
    }
}
