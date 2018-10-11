using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Hello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataBindingPage : ContentPage
	{
		public DataBindingPage ()
		{
            Aluno aluno = InitiAluno("Anderson Silva", "anderson@teste.com");
            BindingContext = aluno;

			InitializeComponent ();
		}

        private Aluno InitiAluno(string nome, string email)
        {
            return new Aluno()
            {
                Id = Guid.NewGuid(),
                Nome = nome,
                Email = email
            };
        }
    }
}