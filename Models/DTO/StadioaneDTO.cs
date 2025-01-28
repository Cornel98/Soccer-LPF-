using System;
namespace PROIECTDaw.Models.DTO
{
	public class StadioaneDTO_cs
	{
            public class StadionDTO
        {
            public int IdStadion { get; set; }
            public int IdLocatie { get; set; }
            public string ?Nume { get; set; }
            public int Capacitate { get; set; }
            public string ? Imagine { get; set; }
            public string ?Oras { get; set; }
            public string ?Tara { get; set; }
            public string ? DenumireLocatie { get; set; }
            public string ? DenumireTara { get; set; }
        }

    }
}


