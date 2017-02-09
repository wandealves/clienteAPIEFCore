using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ClientesAPI.Dominio;

namespace ClientesAPI.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20170209184344_criacao_base")]
    partial class criacao_base
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientesAPI.Dominio.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });
        }
    }
}
