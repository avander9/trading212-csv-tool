using Trading212Tools.Services;

namespace Trading212Tools
{
    public partial class Form1 : Form
    {
        private string FilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            FilePath = openFileDialog1.FileName;
            filePathTextBox.Text = FilePath;
        }

        private async void processButtom_Click(object sender, EventArgs e)
        {
            var parcer = new CSVParserService();

            var inputLines = parcer.ParseFile(FilePath);

            using var cosmosService = new CosmosService();
            if(checboxCleanddbb.Checked)
                await cosmosService.DeleteDatabaseAndCleanupAsync();

            await cosmosService.CreateDDBB();

            foreach (var line in inputLines)
            {
                await cosmosService.AddItemsToContainerAsync(line);
            }
        }
    }
}