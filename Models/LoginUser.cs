using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TradingApp.Models
{
    public class LoginUser
    {
    [Required]
    [EmailAddress]
    [Display( Name= "Login Email")]
    public string LoginEmail {get;set;}
    
    [Required]
    [MinLength(8, ErrorMessage ="Must be at least 8 characters")]
    [DataType(DataType.Password)]
    [Display( Name= "Login Password")]

    public string LoginPassword {get;set;}
    }
}