namespace RTXWebsite1.Models
{
    public class Assignment
    {

        
        // base 64 assignment string
        public string? Assignment_String_Upload { get; set; }


        // assignment type
        public string? Assignment_Type { get; set; }


        // assignment types
        public string PDF_File { get; set; } = "PDF";
        public string Text_File { get; set; } = "Text";
        public string Image_File { get; set; } = "Image";
        public string Word_File { get; set; } = "Word";
        public string Excel_File { get; set; } = "Excel";



        // commants
        public string? Assignment_Comment { get; set; }

    }

}
