using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Text.Json;


namespace _19_05_Classwork
{
    internal class User
    {
        [Required(ErrorMessage = "ID не заданий")]
        [Range(1000,9999, ErrorMessage = "ID має бути в діапазоні 1000-9999")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Login не заданий")]
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Login має містити тільки букви та цифри")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Name не заданий")]
        [EmailAddress(ErrorMessage ="Некоректний Email")]
        public string Email { get; set; }

        [CreditCard(ErrorMessage = "Невалідна картка")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Пароль не заданий")]
        [MinLength(8, ErrorMessage = "Пароль має бути не менше 8 символів")]
        [RegularExpression("^[A-Za-z0-9]+$", ErrorMessage = "Пароль має містити тільки букви та цифри")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword { get; set; }


        [Phone(ErrorMessage = "Невірний формат телефону")]
        [RegularExpression(@"\+38-0\d{2}-\d{3}-\d{2}-\d{2}", ErrorMessage = "Телефон має бути у форматі +38-0XX-XXX-XX-XX")]
        public string Phone { get; set; }       
    }
}
