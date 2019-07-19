#include <iostream>
using namespace std;

typedef struct Link
{
	int value;
	struct Link *next;
	
}link;


link * initLink()
{
	//创建一个空节点 指向第一个有值的节点
	
	link * p= new link();//创建一个头结点
    link * temp=p;//声明一个指针指向头结点，用于遍历链表
    //生成链表
    for (int i=1; i<12; i++) {
        link *a= new link();
        a->value=i;
        a->next=NULL;
        temp->next=a;
        temp=temp->next;
    }
    return p;
}

void display(link * head)
{
	link* temp=head;//将temp指针重新指向头结点
    //只要temp指针指向的结点的next不是Null，就执行输出语句。
    while (temp->next) {
        temp=temp->next;
        cout << temp->value <<endl;
    }
}

link * insert(link * head,int index,int value)
{
	link * p = head;
	for(int i = 1;i < index ;++i)
	{
		if (p==NULL) {
			cout << "插入位置无效\n" <<endl;
            return head;
        }
		cout << "i:" << i << " " ;
		p  = p->next;	
		cout << "p value:" << p->value << " " ;
	}
	cout <<endl;
	
	link * n = new link();
	n->value = value;
	n->next = p->next;
	p->next = n;
	return head;	
	
}

link * insertElem(link * p,int elem,int add){
    link * temp=p;//创建临时结点temp
    //首先找到要插入位置的上一个结点
    for (int i=1; i<add; i++) {
        if (temp==NULL) {
            printf("插入位置无效\n");
            return p;
        }
        temp=temp->next;
    }
    //创建插入结点c
    link * c= new link();
    c->value=elem;
    //向链表中插入结点
    c->next=temp->next;
    temp->next=c;
    return  p;
}

link * remove(link * head,int index)
{
	link * p = head;
	for(int i = 1;i < index ;++i)
	{
		p  = p->next;	
	}
	link * del = p->next;
	p->next = p->next->next;
	delete []del;
	del  = NULL;
	return head;	
	
}

int main()
{
	link * head =  initLink();
	display(head);
	
	link * nHead = insertElem(head,10,5);
	display(nHead);
	
	// link * nnHead = remove(nHead,5);
	// display(nnHead);
	
	return 0;
}