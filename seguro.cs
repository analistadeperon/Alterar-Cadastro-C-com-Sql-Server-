private void btnAlterar_Click(object sender, EventArgs e)
 
{
try
{
if (txtCodigo.Text != "")
{
SqlConnection conn = new SqlConnection(@"Data Source=DAMASCENO-PC\SQLEXPRESS1;
Initial Catalog=cadcd;Integrated Security=True;Pooling=False");
SqlCommand comm = new SqlCommand();
comm.Connection = conn;
comm.CommandText = "UPDATE cadcd SET TIPO = '" + ddlTipo.Text + "', TITULO = '" + txtTitulo.Text + "', DESCRICAO = '" + richTxtDescr.Text +
"WHERE REGISTRO = " + (txtCodigo.Text) + "";
// UPDATE cadcd set TIPO='-DIVERSOS', TITULO='TESTE1', DESCRICAO='TESTE1' where REGISTRO=007
comm.Parameters.AddWithValue("@REGISTRO", txtCodigo.Text);
comm.Parameters.AddWithValue("@TIPO", ddlTipo.Text);
comm.Parameters.AddWithValue("@TITULO", txtTitulo.Text);
comm.Parameters.AddWithValue("@DESCRICAO", richTxtDescr.Text);
conn.Open();
conn.Close();
MessageBox.Show("Midia alterada com sucesso!");
}
else
{
MessageBox.Show("Informe o código da mídia");
}
}
