using System;
using System.Collections.Generic;
using System.Text;

// створюємо базовий клас для елементів та текстових вузлів
public abstract class LightNode 
{
}

// створюємо клас для елементів
public class LightElementNode : LightNode
{
    // властивості для зберігання інформації про елемент
    public string TagName { get; set; }
    public bool IsBlock { get; set; }
    public bool IsSelfClosing { get; set; }
    public List<string> CssClasses { get; set; }
    public List<LightNode> Children { get; set; }

    // властивості для отримання внутрішнього та зовнішнього HTML
    public string OuterHTML => GetOuterHTML();
    public string InnerHTML => GetInnerHTML();

    // конструктор для створення елемента
    public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
    {   
        TagName = tagName;
        IsBlock = isBlock;
        IsSelfClosing = isSelfClosing;
        CssClasses = new List<string>();
        Children = new List<LightNode>();
    }

    // методи для роботи з дочірніми вузлами
    public void AppendChild(LightNode node)
    {
        Children.Add(node);
    }

    public void ReplaceChild(LightNode node, int index)
    {
        Children[index] = node;
    }

    public void RemoveChild(int index)
    {
        Children.RemoveAt(index);
    }

    public void InsertBefore(LightNode node, int refIndex)
    {
        Children.Insert(refIndex, node);
    }

    // метод для клонування елемента
    public LightElementNode Clone()
    {
        var clone = new LightElementNode(TagName, IsBlock, IsSelfClosing)
        {
            CssClasses = new List<string>(CssClasses) // клонуємо список класів за допомогою конструктора копіювання
        };

        // клонуємо дочірні вузли
        foreach (var child in Children)
        {
            if (child is LightElementNode elementNode)
            {
                clone.AppendChild(elementNode.Clone());
            }
            else if (child is LightTextNode textNode)
            {
                clone.AppendChild(new LightTextNode(textNode.Text));
            }
        }

        return clone;
    }

    // методи для отримання внутрішнього та зовнішнього HTML
    private string GetOuterHTML()
    {
        var cssClasses = string.Join(" ", CssClasses);
        var innerHtml = GetInnerHTML();
        var tag = IsSelfClosing ? $"<{TagName} class=\"{cssClasses}\"/>" : $"<{TagName} class=\"{cssClasses}\">{innerHtml}</{TagName}>";

        return tag;
    }

    // метод для отримання внутрішнього HTML7 
    private string GetInnerHTML()
    {
        var htmlBuilder = new StringBuilder();

        foreach (var child in Children)
        {
            if (child is LightElementNode elementNode)
            {
                htmlBuilder.Append(elementNode.OuterHTML);
            }
            else if (child is LightTextNode textNode)
            {
                htmlBuilder.Append(textNode.Text);
            }
        }

        return htmlBuilder.ToString();
    }
}

// створюємо клас для текстових вузлів
public class LightTextNode : LightNode
{
    public string Text { get; set; }

    public LightTextNode(string text)
    {
        Text = text;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Завантажуємо текст книги з файла.
        // Використайте власний шлях до файлу з текстом.
        var bookLines = File.ReadAllLines("book.txt");

        // Перетворюємо текст книги в HTML згідно з вказаними правилами.
        var bookHtml = ConvertBookToHtml(bookLines);

        // Виводимо HTML на екран.
        Console.WriteLine(bookHtml.OuterHTML);
    }

    static LightElementNode ConvertBookToHtml(string[] bookLines)
    {
        var root = new LightElementNode("div", true, false);

        for (int i = 0; i < bookLines.Length; i++)
        {
            var line = bookLines[i];
            LightElementNode node;

            if (i == 0)
            {
                node = new LightElementNode("h1", true, false);
            }
            else if (line.Length < 20)
            {
                node = new LightElementNode("h2", true, false);
            }
            else if (line.StartsWith(' '))
            {
                node = new LightElementNode("blockquote", true, false);
            }
            else
            {
                node = new LightElementNode("p", true, false);
            }

            node.AppendChild(new LightTextNode(line));
            root.AppendChild(node);
        }

        return root;
    }
}

