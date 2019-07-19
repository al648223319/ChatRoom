#include <iostream>
using namespace std;

typedef struct Link
{
	int value;
	struct Link *next;
	
}link;


link * initLink()
{
	//����һ���սڵ� ָ���һ����ֵ�Ľڵ�
	
	link * p= new link();//����һ��ͷ���
    link * temp=p;//����һ��ָ��ָ��ͷ��㣬���ڱ�������
    //��������
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
	link* temp=head;//��tempָ������ָ��ͷ���
    //ֻҪtempָ��ָ��Ľ���next����Null����ִ�������䡣
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
			cout << "����λ����Ч\n" <<endl;
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
    link * temp=p;//������ʱ���temp
    //�����ҵ�Ҫ����λ�õ���һ�����
    for (int i=1; i<add; i++) {
        if (temp==NULL) {
            printf("����λ����Ч\n");
            return p;
        }
        temp=temp->next;
    }
    //����������c
    link * c= new link();
    c->value=elem;
    //�������в�����
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