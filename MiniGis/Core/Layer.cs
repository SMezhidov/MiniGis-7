using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGis.Core
{
    public class Layer
    {
        public List<MapObject> _objects = new List<MapObject>();
        private Bounds _bounds = new Bounds();

        public MapObject this[int index]
        {
            get
            {
                return _objects[index];
            }
            set
            {
                _objects[index] = value;
            }
        }

        public Map Map
        {
            get;
            set;    
        }

        public void AddObject(MapObject obgect)
        {
            if (obgect.Layer != null)
                throw new Exception("объект уже добален в слой"); //не одволяет добавлять один и тотже объект в разные слои, тоже самое можно сделать с мапом
            _objects.Add(obgect);
            obgect.Layer = this;
        }

        public void RemoveObject(int index)
        {
            _objects.RemoveAt(index);
        }

        public void ClearObjects()
        {
            _objects.Clear();
        }

        public MapObject GetObject(int index)
        {
            return _objects[index];
        }

        public int ObjectCount
        {
            get
            {
                return _objects.Count();
            }
        }

        internal void Paint(PaintEventArgs e)
        {
           // здесь будет код рисования слоя
           for (int i = ObjectCount - 1; i >= 0; i--)
           {
                MapObject mapObject = GetObject(i);
                mapObject.Paint(e);
           }
        }
        //хранение границ (свойство)
        public Bounds Bounds
        {
            get
            {
                return _bounds;
            }
        }
        //обновление границ
        public void UpdateBounds()
        {
            Bounds bounds = new Bounds();
            foreach (MapObject obj in _objects)
            {
                bounds = Bounds.Union(bounds, obj.Bounds);
                _bounds = bounds;
            }

        }
        public void ClearSelectedObjects()
        {
            for (int i  = _objects.Count-1;i>=0;i--)
            {
                _objects[i].Selected = false;
            }
            
        }

        internal MapObject FindObject(Node searchpoint, double quad)
        {
            MapObject foundobject;
            for (int i = _objects.Count - 1; i >= 0; i--)
            {
                foundobject = _objects[i];
                if (foundobject.IsIntersects(searchpoint, quad))
                {
                    return foundobject;
                }
            }
            return null;
        }

       
    }
}
