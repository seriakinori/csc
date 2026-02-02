using System.ComponentModel.DataAnnotations;

public class userModel
{
    [StringLength(16,ErrorMessage = "User name is too long.")]
    public string name {get; set;} = string.Empty;
    [Range(0,130, ErrorMessage = "Excess age range.")]
    public int Age{get;set;}
}