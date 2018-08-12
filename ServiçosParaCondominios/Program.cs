using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiçosParaCondominios
{
    static class Program
    {
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		/// 

		public static DTO.DTO_Sindico sindico_login = new DTO.DTO_Sindico();
		public static DTO.DTO_Conservadora conservadora_login = new DTO.DTO_Conservadora();

		[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Frm_login login = new Frm_login();

            Application.Run(new Frm_Relatorio());

            DialogResult result = login.ShowDialog();
			if (result == DialogResult.OK)
				Application.Run(new Frm_MenuSindico());
			if (result == DialogResult.Yes)
				Application.Run(new Frm_MenuConservadora());
		}
    }
}
