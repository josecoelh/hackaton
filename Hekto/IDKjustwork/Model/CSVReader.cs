namespace IDKjustwork.Model
{
    public static class CSVReader

    {

         //method that reads from csv into list of Model  
         public static List<Model> ReadCSV(string path,string separator)
        {
            List<Model> list = new List<Model>();
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(separator);
                    Model model = new Model();
                    model.SKU = values[0];
                    model.DisplayName = values[1];
                    model.description = values[2];
                    model.brand = values[3];
                    model.category = values[4];
                    model.MaxPrice = values[5];
                    model.Upc = values[6];
                    model.VatCode = values[7];
                    model.secondaryUnitPrice = values[8];
                    model.SecondaryUnit = values[9];
                    model.urlImagem = values[10];
                    list.Add(model);
                }
            }
            return list;
        }


        
    }
}
