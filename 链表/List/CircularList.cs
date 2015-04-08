using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List
{
    class CircularNode
    {
        //成员变量
        private object _data;//数据
        private CircularNode _next;//后指针
        public object Data
        {
            get { return _data; }
        }
        public CircularNode Next
        {
            get { return _next; }
            set { _next = value; }
        }
        //构造函数
        public CircularNode(object data)
        {
            _data = data;
        }
        public override string ToString()
        {
            return _data.ToString();
        }
    }
    class CircularList
    {
        private CircularNode _head;//循环链表头指针
        private string str;//用于构造循环链表的字符串
        public CircularNode Head
        {
            get { return _head; }
        }
        //构造方法
        public CircularList(string Str)
        {
            str = Str;
            _head = new CircularNode(str[0]);
            int i=1;
            CircularNode now,tailTemp;
            tailTemp = now = _head;
            while (i < str.Length)
            {
                now = new CircularNode(str[i]);
                i++;
                now.Next = _head;
                _head = now;
            }
            tailTemp.Next = _head;
        }
        public override string ToString()
        {
            string Str="";
            CircularNode now = _head;
            if (now == null) return Str;
            Str += now.Data;
            now = now.Next;
            while (now != _head)
            {
                Str+=now.Data;
                now = now.Next;
            }
            return Str;
        }
        public void Insert(string Str)
        {
            int i = 0;
            CircularNode HeadTemp,tailTemp=_head;
            while (tailTemp!=null&&tailTemp.Next != _head) tailTemp = tailTemp.Next;
            while (i < Str.Length)
            {
                HeadTemp = _head;
                _head = new CircularNode(Str[i]);
                _head.Next = HeadTemp;
                i++;
            }
            tailTemp.Next = _head;
        }
        public void Search(string Str)
        {
            string sTemp;
            int i = 1,Times=0;
            CircularNode HeadTemp;
            HeadTemp = _head;
            for (int j = 0;HeadTemp!=null && j < Str.Length; j++)
            {
                if ((char)HeadTemp.Data != Str[j]) continue;
                sTemp = string.Format("第{0}个元素是{1}.", i , Str[j]);
                MessageBox.Show(sTemp, "提示",
                MessageBoxButtons.OK, MessageBoxIcon.None);
                Times++; break;
            }
            i++;
            HeadTemp = HeadTemp.Next;
            while (HeadTemp != _head)
            {
                for(int j=0;j<Str.Length;j++)
                {
                    if ((char)HeadTemp.Data != Str[j]) continue;
                    sTemp = string.Format("第{0}个元素是{1}.", i, Str[j]);
                    MessageBox.Show(sTemp, "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                    Times++; break;
                }
                i++;
                HeadTemp = HeadTemp.Next;
            }
            if (Times==0) MessageBox.Show("不存在所要查找的元素.", "提示",
                      MessageBoxButtons.OK, MessageBoxIcon.None); 
        }
        public void Delete(string Str)
        {
            int  Times = 0,pTimes=0;
            CircularNode HeadTemp, PointTemp, preTemp;
            preTemp = new CircularNode('0');
            HeadTemp = preTemp;
            preTemp.Next = _head;
            PointTemp = preTemp.Next;
            if (PointTemp != null)
            {
                for (int j = 0; PointTemp != null && j < Str.Length; j++)
                {
                    if ((char)PointTemp.Data != Str[j]) continue;
                    preTemp.Next = PointTemp.Next;
                    PointTemp = PointTemp.Next;
                    Times++; break;
                }
                if (Times > pTimes) pTimes = Times;
                else
                {
                    preTemp = preTemp.Next;
                    PointTemp = PointTemp.Next;
                }
            }
            while (PointTemp!= _head)
            {
                for (int j = 0; PointTemp != null && j < Str.Length; j++)
                {
                    if ((char)PointTemp.Data != Str[j]) continue;
                    preTemp.Next = PointTemp.Next;
                    PointTemp = PointTemp.Next;
                    Times++; break;
                }
                if (Times > pTimes) { pTimes = Times; continue; }
                    preTemp = preTemp.Next;
                    PointTemp = PointTemp.Next;
            }
            if (Times == 0) MessageBox.Show("不存在所要删除的元素.", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
            _head = HeadTemp.Next;
            preTemp.Next = _head;
            for (int j = 0;_head!=null&&j < Str.Length; j++)
            {
                if ((char)_head.Data != Str[j]) continue;
                _head = null;
            }
        }
    }
}
