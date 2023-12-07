using System;
using System.Collections.Generic;

public class Biblioteca
{
    private List<ItemBiblioteca> colecao;

    public Biblioteca()
    {
        colecao = new List<ItemBiblioteca>();
    }

    // Método para adicionar um item à coleção
    public void AdicionarItem(ItemBiblioteca item)
    {
        colecao.Add(item);
    }

    // Método para remover um item da coleção
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
    }

    // Sobrecarga do método para buscar um item por título
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    {
        return colecao.Find(item => item.Titulo == titulo);
    }

    // Sobrecarga do método para buscar um item por ID
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.Id == id);
    }
}