using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangle_getset
{
    class Box
    {
        public int MyProperty { get; set; } //prop 치고 탭+탭

        private int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; } //propfull 을 적고 탭탭
        }


        private int width;
        public int mWidth
        {
            get
            {
                return width;
            }
            set
            {
                if(value > 0)
                {
                    width = value;
                }
                else
                {
                    MessageBox.Show("0이상 입력바람");
                }
            }
        }

        private int height;
        public int mHeight
        {
            get
            {
                return height;
            }
            set
            {
                if(value>0)
                {
                    height = value;
                }
                else
                {
                    MessageBox.Show("0이상 입력바람");
                }
            }
    
        }
       

        //public Box(int w, int h)
        //{
        //    if(w > 0 && h > 0)
        //    {
        //        this.width = w;
        //        this.height = h;
        //    }
        //    else
        //    {
        //        MessageBox.Show("자연수로 초기화 부탁 ");
        //    }

        //}

        public double Area()
        {
            return width * height;
        }

        //Getter
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }


        //Setter
        public void SetWidth(int w)
        {
            if (w > 0)
            {
                this.width = w;
            }
            else
            {
                MessageBox.Show("너비는 자연수를 입력해주세요");
            }
        }

        public void SetHeight(int h)
        {
            if (h > 0)
            {
                this.width = h;
            }
            else
            {
                MessageBox.Show("높이는 자연수를 입력해주세요");
            }
        }


    }
}
