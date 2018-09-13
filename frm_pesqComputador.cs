using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestao_de_Parque_Computacional.Forms
{
    public partial class frm_pesqComputador : Form
    {
        public frm_pesqComputador()
        {
            InitializeComponent();
            
            
            
            
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            grid_computador.Rows.Clear();

            if(check_ns.Checked == true)
            {
                //relatório que pesquisa por numero de série
            }
            if(check_inativos.Checked == true)
            {
                //relatório que pesquisa todos os inativos
            }
            if(check_fornecedor.Checked == true)
            {
                //relatório que pesquisa por fornecedor
            }
            if(check_config.Checked == true)
            {
                //relatório que pesquisa por configuração
                WsComputador.Computador obj1 = new WsComputador.Computador();
                WsComputador.Computador obj2 = new WsComputador.Computador();
                WsComputador.WsComputadorClient computadorDAO = new WsComputador.WsComputadorClient();

                obj1.tamanhomemoria = Convert.ToInt32(cmb_tamanhomemoria.SelectedValue);
            }
            if (check_chefe.Checked == true)
            {
                //relatório que pesquisa por chefe de departamento
            }
            else
            {
                WsComputador.WsComputadorClient computadorDAO = new WsComputador.WsComputadorClient();
                List<WsComputador.Computador> listcomputador = new List<WsComputador.Computador>();

                string retorno = computadorDAO.wsPesquisarTodos();
                listcomputador = JsonConvert.DeserializeObject<List<WsComputador.Computador>>(retorno);

                grid_computador.AutoGenerateColumns = false;

                for (int i = 0; i < listcomputador.Count; i++)
                    grid_computador.Rows.Add(listcomputador[i].id, listcomputador[i].numeroserie, listcomputador[i].modelomemoria, listcomputador[i].tamanhomemoria, listcomputador[i].modelohd, listcomputador[i].tamanhohd, listcomputador[i].processador, listcomputador[i].frequenciaprocessador, listcomputador[i].placamae, listcomputador[i].modeloplacavideo, listcomputador[i].tamanhoplacavideo, listcomputador[i].chefedpto.nome, listcomputador[i].fornecedor.razaosocial, listcomputador[i].ativo);

            }

        }

        private void frm_pesqComputador_Load(object sender, EventArgs e)
        {
            //CARREGA COMBO TAMANHO HD
            List<WsComputador.Computador> listtamanhohd = new List<WsComputador.Computador>();
            listtamanhohd.Add(new WsComputador.Computador { tamanhohd = 0 });
            listtamanhohd.Add(new WsComputador.Computador { tamanhohd = 254 });
            listtamanhohd.Add(new WsComputador.Computador { tamanhohd = 512 });
            listtamanhohd.Add(new WsComputador.Computador { tamanhohd = 1024 });
            listtamanhohd.Add(new WsComputador.Computador { tamanhohd = 2048 });
            cmb_tamanhohd.DataSource = listtamanhohd;
            cmb_tamanhohd.ValueMember = "tamanhohd";
            cmb_tamanhohd.DisplayMember = "tamanhohd";

            //CARREGA COMPUTO TAMANHO MEMORIA
            List<WsComputador.Computador> listtamanhomemoria = new List<WsComputador.Computador>();
            listtamanhomemoria.Add(new WsComputador.Computador { tamanhomemoria = 0 });
            listtamanhomemoria.Add(new WsComputador.Computador { tamanhomemoria = 1 });
            listtamanhomemoria.Add(new WsComputador.Computador { tamanhomemoria = 2 });
            listtamanhomemoria.Add(new WsComputador.Computador { tamanhomemoria = 4 });
            listtamanhomemoria.Add(new WsComputador.Computador { tamanhomemoria = 8 });
            cmb_tamanhomemoria.DataSource = listtamanhomemoria;
            cmb_tamanhomemoria.ValueMember = "tamanhomemoria";
            cmb_tamanhomemoria.DisplayMember = "tamanhomemoria";


            //CARREGA A COMBO FREQUENCIA DE PROCESSADOR
            List<WsComputador.Computador> listfrequencia = new List<WsComputador.Computador>();
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 0 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 1.1 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 1.3 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 1.5 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 1.8 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 2.1 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 2.5 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 2.9 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 3.5 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 4.1 });
            listfrequencia.Add(new WsComputador.Computador { frequenciaprocessador = 4.5 });
            cmb_processador.DataSource = listfrequencia;
            cmb_processador.ValueMember = "frequenciaprocessador";
            cmb_processador.DisplayMember = "frequenciaprocessador";

            //CARREGA COMBO TAMANHO PLACA DE VIDEO
            List<WsComputador.Computador> listtamanhoplacavideo = new List<WsComputador.Computador>();
            listtamanhoplacavideo.Add(new WsComputador.Computador { tamanhoplacavideo = 0 });
            listtamanhoplacavideo.Add(new WsComputador.Computador { tamanhoplacavideo = 1 });
            listtamanhoplacavideo.Add(new WsComputador.Computador { tamanhoplacavideo = 2 });
            listtamanhoplacavideo.Add(new WsComputador.Computador { tamanhoplacavideo = 4 });
            listtamanhoplacavideo.Add(new WsComputador.Computador { tamanhoplacavideo = 8 });
            cmb_tamanhoplacavideo.DataSource = listtamanhoplacavideo;
            cmb_tamanhoplacavideo.ValueMember = "tamanhoplacavideo";
            cmb_tamanhoplacavideo.DisplayMember = "tamanhoplacavideo";




            //CARREGA COMPUTO TAMANHO MEMORIA
            List<WsComputador.Computador> listtamanhomemoria2 = new List<WsComputador.Computador>();
            listtamanhomemoria2.Add(new WsComputador.Computador { tamanhomemoria = 0 });
            listtamanhomemoria2.Add(new WsComputador.Computador { tamanhomemoria = 1 });
            listtamanhomemoria2.Add(new WsComputador.Computador { tamanhomemoria = 2 });
            listtamanhomemoria2.Add(new WsComputador.Computador { tamanhomemoria = 4 });
            listtamanhomemoria2.Add(new WsComputador.Computador { tamanhomemoria = 8 });
            cmb_tamanhomemoria2.DataSource = listtamanhomemoria2;
            cmb_tamanhomemoria2.ValueMember = "tamanhomemoria";
            cmb_tamanhomemoria2.DisplayMember = "tamanhomemoria";

            //CARREGA COMBO TAMANHO HD
            List<WsComputador.Computador> listtamanhohd2 = new List<WsComputador.Computador>();
            listtamanhohd2.Add(new WsComputador.Computador { tamanhohd = 0 });
            listtamanhohd2.Add(new WsComputador.Computador { tamanhohd = 254 });
            listtamanhohd2.Add(new WsComputador.Computador { tamanhohd = 512 });
            listtamanhohd2.Add(new WsComputador.Computador { tamanhohd = 1024 });
            listtamanhohd2.Add(new WsComputador.Computador { tamanhohd = 2048 });
            cmb_tamanhohd2.DataSource = listtamanhohd2;
            cmb_tamanhohd2.ValueMember = "tamanhohd";
            cmb_tamanhohd2.DisplayMember = "tamanhohd";


            //CARREGA A COMBO FREQUENCIA DE PROCESSADOR
            List<WsComputador.Computador> listfrequencia2 = new List<WsComputador.Computador>();
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 0 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 1.1 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 1.3 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 1.5 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 1.8 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 2.1 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 2.5 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 2.9 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 3.5 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 4.1 });
            listfrequencia2.Add(new WsComputador.Computador { frequenciaprocessador = 4.5 });
            cmb_processador2.DataSource = listfrequencia;
            cmb_processador2.ValueMember = "frequenciaprocessador";
            cmb_processador2.DisplayMember = "frequenciaprocessador";

            //CARREGA COMBO TAMANHO PLACA DE VIDEO
            List<WsComputador.Computador> listtamanhoplacavideo2 = new List<WsComputador.Computador>();
            listtamanhoplacavideo2.Add(new WsComputador.Computador { tamanhoplacavideo = 0 });
            listtamanhoplacavideo2.Add(new WsComputador.Computador { tamanhoplacavideo = 1 });
            listtamanhoplacavideo2.Add(new WsComputador.Computador { tamanhoplacavideo = 2 });
            listtamanhoplacavideo2.Add(new WsComputador.Computador { tamanhoplacavideo = 4 });
            listtamanhoplacavideo2.Add(new WsComputador.Computador { tamanhoplacavideo = 8 });
            cmb_tamanhoplacavideo2.DataSource = listtamanhoplacavideo;
            cmb_tamanhoplacavideo2.ValueMember = "tamanhoplacavideo";
            cmb_tamanhoplacavideo2.DisplayMember = "tamanhoplacavideo";
        }

        private void check_ns_CheckedChanged(object sender, EventArgs e)
        {
            if (check_ns.Checked == true) { check_inativos.Checked = false; check_fornecedor.Checked = false; check_config.Checked = false; check_chefe.Checked = false; }

        }

        private void check_inativos_CheckedChanged(object sender, EventArgs e)
        {
            if (check_inativos.Checked == true) { check_ns.Checked = false; check_fornecedor.Checked = false; check_config.Checked = false; check_chefe.Checked = false; }
            
        }

        private void check_fornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (check_fornecedor.Checked == true) { check_ns.Checked = false; check_inativos.Checked = false; check_config.Checked = false; check_chefe.Checked = false; }
            
        }

        private void check_config_CheckedChanged(object sender, EventArgs e)
        {
            if (check_config.Checked == true) { check_ns.Checked = false; check_inativos.Checked = false; check_fornecedor.Checked = false; check_chefe.Checked = false; }
            
        }

        private void check_chefe_CheckedChanged(object sender, EventArgs e)
        {
            if (check_chefe.Checked == true) { check_ns.Checked = false; check_inativos.Checked = false; check_fornecedor.Checked = false; check_config.Checked = false; }

        }
    }
}
