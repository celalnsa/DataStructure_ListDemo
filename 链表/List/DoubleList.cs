using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace List
{
    class DoubleNode
    { 
        //成员变量
        private object _data;//数据
        private DoubleNode _prior;//前指针
        private DoubleNode _next;//后指针
        public object Data
        {
            get { return _data; }
        }
        public DoubleNode Prior
        {
            get {return _prior;}
            set {_prior =value;}
        }
        public DoubleNode Next
        {
            get { return _next; }
            set { _next = value; }
        }
        //构造函数
        public DoubleNode(object data)
        {
            _data = data;
        }
        public override string ToString()
        {
            return _data.ToString();
        }
    }
    class DoubleList
    {
        private DoubleNode _head;//单链表头指针
        private string str;//用于构造单链表的字符串
        public DoubleNode Head
        {
            get { return _head; }
        }
        //构造方法
        public DoubleList(string Str)
        {
            str = Str;
            _head = new DoubleNode(str[0]);
            int i = 1;
            DoubleNode now = _head;
            while (i < str.Length)
            {
                now = new DoubleNode(str[i]);
                i++;
                now.Next = _head;
                _head.Prior = now;
                _head = now;
            }
        }
        public override string ToString()
        {
            string Str = "";
            DoubleNode now = _head;
            while (now != null)
            {
                Str += now.Data;
                now = now.Next;
            }
            return Str;
        }
        public void Insert(string Str)
        {
            int i = 0;
            DoubleNode HeadTemp;
            while (i < Str.Length)
            {
                HeadTemp = _head;
                _head = new DoubleNode(Str[i]);
                _head.Next = HeadTemp;
                if (HeadTemp!=null) HeadTemp.Prior = _head;
                i++;
            }
        }
        public void Search(string Str)
        {
            string sTemp;
            int i = 1, Times = 0;
            DoubleNode HeadTemp;
            HeadTemp = _head;
            while (HeadTemp != null)
            {
                for (int j = 0; j < Str.Length; j++)
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
            if (Times == 0) MessageBox.Show("不存在所要查找的元素.", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public void Delete(string Str)
        {
            int Times = 0, pTimes = 0;
            DoubleNode HeadTemp, PointTemp, preTemp;
            preTemp = new DoubleNode('0');
            HeadTemp = preTemp;
            preTemp.Next = _head;
            PointTemp = preTemp.Next;
            while (PointTemp != null)
            {
                for (int j = 0; PointTemp != null && j < Str.Length; j++)
                {
                    if ((char)PointTemp.Data != Str[j]) continue;
                    preTemp.Next = PointTemp.Next;
                    PointTemp = PointTemp.Next;
                    if (PointTemp != null) PointTemp.Prior = preTemp;
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
