namespace EntityFrameWorkApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach(Acteur acteur in acteurList)
            //{
            //    acteur.Personnages=context.Personnages.Where(p=> p.ActeurId==acteur.Id).ToList();
            //}
           
            Populate();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //if(acteur == null)
            //{
            //    context.Add(new Acteur() { Nom=textBoxNom.Text, Prenom=textBoxPrnom.Text});
            //}
            //else
            //{
            //    acteur.Nom=textBoxNom.Text;
            //    acteur.Prenom=textBoxPrnom.Text;
            //}
            //context.SaveChanges();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           // acteurList = context.Acteurs.Where(a => a.Prenom.Contains(textBoxPrnom.Text) && a.Nom.Contains(textBoxNom.Text)).ToList();
            Populate();
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
            }
        }

        private void Populate()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}