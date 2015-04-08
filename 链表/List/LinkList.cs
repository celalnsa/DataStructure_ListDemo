using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List
{
    class LinkNode
    {
        //成员变量
        private object _data;//数据
        private LinkNode _next;//后指针
        public object Data
        {
            get { return _data; }
        }
        public LinkNode Next
        {
            get { return _next; }
            set { _next = value; }
        }
        //构造函数
        public LinkNode(object data)
        {
            _data = data;
        }
        public override string ToString()
        {
            return _data.ToString();
        }
    }
    class LinkList
    {
        private LinkNode _head;//单链表头指针
        private string str;//用于构造单链表的字符串
        public LinkNode Head
        {
            get { return _head; }
        }
        //构造方法
        public LinkList(string Str)
        {
            str = Str;
            _head = new LinkNode(str[0]);
            int i=1;
            LinkNode now=_head ;
            while (i < str.Length)
            {
                now= new LinkNode(str[i]);
                i++;
                now.Next = _head;
                _head = now;
            }
        }
        public override string ToString()
        {
            string Str="";
            LinkNode now=_head;
            while (now != null)
            {
                Str+=now.Data;
                now = now.Next;
            }
            return Str;
        }
        public void Insert(string Str)
        {
            int i = 0;
            LinkNode HeadTemp;
            while (i < Str.Length)
            {
                HeadTemp = _head;
                _head = new LinkNode(Str[i]);
                _head.Next = HeadTemp;
                i++;
            }
        }
        public void Search(string Str)
        {
            string sTemp;
            int i = 1,Times=0;
            LinkNode HeadTemp;
            HeadTemp = _head;
            while (HeadTemp != null)
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
            LinkNode HeadTemp,PointTemp,preTemp;
            preTemp = new LinkNode('0');
            HeadTemp = preTemp;
            preTemp.Next = _head;
            PointTemp = preTemp.Next;
            while (PointTemp!= null)
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
        }
    }
}
