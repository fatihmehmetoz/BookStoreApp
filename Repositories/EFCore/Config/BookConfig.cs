using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "Alacakaranlık",
                    Price = 100,
                },
                new Book
                {
                    Id = 2,
                    Title = "Dune",
                    Price = 150,
                },
                new Book
                {
                    Id = 3,
                    Title = "Olasılıksız",
                    Price = 200,

                }
                );
        }
    }
}
