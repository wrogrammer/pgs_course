﻿namespace PGSBoard.ViewModels
{

    //This is viewModel for card, it contains only card data: name and description

    public class CardViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public CardViewModel(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}