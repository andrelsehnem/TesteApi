using Refit;
using System;

using System.Threading.Tasks;
using System.Windows.Forms;
using TesteApi.Objetos;

namespace TesteApi.Forms
{
    partial class frmConsultaCep : Form
    {
        public frmConsultaCep()
        {
            InitializeComponent();
            
        }

        private void frmConsultaCep_Load(object sender, EventArgs e)
        {

        }

        public interface ICepApiService
        {
            [Get("/ws/{cep}/json")]
            Task<Endereco> GetAddressAsync(string cep);
        }

        private void bt_Busca_Click(object sender, EventArgs e)
        {
            busca();
        }


        async Task busca()
        {
            try{
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                string cepInformado = txt_cep.Text;

                var address = await cepClient.GetAddressAsync(cepInformado);

                preenche(address);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na consulta de CEP \n" + e.ToString());
            }
        }

        private void preenche(Endereco address)
        {
            txt_logradouro.Text = address.logradouro;
            txt_complemento.Text = address.complemento;
            txt_bairro.Text = address.bairro;
            txt_localidade.Text = address.localidade;
            txt_uf.Text = address.uf;
            txt_ibge.Text = address.ibge;
            txt_gia.Text = address.gia;
            txt_ddd.Text = address.ddd;
            txt_siafi.Text = address.siafi;
        }
    }
}
