namespace RapidApiHotelProject.Dtos
{
    public class ResultLocationDto
    {

            public bool status { get; set; }
            public string message { get; set; }
            public long timestamp { get; set; }
            public string[] data { get; set; }

    }
}
