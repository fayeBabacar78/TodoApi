using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {

        public TodoItem() => IsCompleted = false;
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        public string? Name { get; set; }

        public bool IsCompleted { get; set; }

        public string? Secret { get; set; }
    }
}
