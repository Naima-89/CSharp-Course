namespace week2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //creat a variable to store user input
            String FirstName, SecondName, LastName,FullName;

            //initialize the variable with user input
            FirstName = TextFirstName.Text;
            SecondName = TextSecondName.Text;
            LastName = TextLastName.Text;
            //Process concatenation of the two strings
            FullName = FirstName + " " + SecondName + " " + LastName;   
            //Show the output in the label
            lblouput.Text = FullName;
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {    //clear the textboxes
            TextFirstName.Clear();
            TextSecondName.Text = "";
            TextLastName.Text = String.Empty;
            lblouput.Text = "";

        }

        private void lblouput_Click(object sender, EventArgs e)
        {

        }
    }
}