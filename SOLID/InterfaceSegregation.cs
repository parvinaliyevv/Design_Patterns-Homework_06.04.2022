using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IControl
    {
        public void IAddChild(object item);
    }

    public interface IVisibleControl : IControl
    {
        public void Hit();
    }


    /// <summary>
    /// Both derived classes can add items, but one of them can be clicked
    /// </summary>
    public abstract class Control
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class ContentControl : Control, IVisibleControl
    {
        public object Content { get; set; }

        public ContentControl() => Content = new();


        public void Hit() => Console.WriteLine(string.Format("Content Control Mouse clicked!"));

        public void IAddChild(object item)
        {
            Content = item;
            Console.WriteLine("Content changed to new element");
        }
    }


    public class ItemsControl : Control, IControl
    {
        public List<object> Items { get; set; }

        public ItemsControl() => Items = new();

        public void IAddChild(object item)
        {
            Items.Add(item);
            Console.WriteLine("Item added to ItemsControl!");
        }
    }
}
