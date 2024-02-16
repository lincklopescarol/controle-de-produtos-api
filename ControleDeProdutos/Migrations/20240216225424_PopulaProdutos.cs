using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleDeProdutos.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
                "Values('Coca-Cola Diet','Refrigerante de Coca Cola 350 ml',5.45,'cocacola.png',50,now(),1)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
               "Values('Lanche de Queijo','Lanche de Queijo com Tomate',5.50,'lanche.png',10,now(),2)");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " +
               "Values('Bolo','Bolo de Chocolate',8.50,'bolo.png',20,now(),3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produtos");
        }
    }
}
