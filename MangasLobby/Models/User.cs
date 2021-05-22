using System;
using System.ComponentModel.DataAnnotations;

namespace MangasLobby.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; }
    }
}
