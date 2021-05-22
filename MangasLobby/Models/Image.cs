using System;
using System.ComponentModel.DataAnnotations;

namespace MangasLobby.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string OriginalName { get; set; }
        public string Path { get; set; }
        public long size { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; }
    }
}
