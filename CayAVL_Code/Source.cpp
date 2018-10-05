#include <iostream>
using namespace std;
struct node {
	int info;
	struct node *pLeft;
	struct node *pRight;
};
typedef struct  node NODE;
typedef NODE* TREE;
//Khoi tao cay
void Createtree(TREE &t) {
	t = NULL;
}
void Addnode(TREE &t, int x) {
	if (t == NULL) {//Cay rong
		NODE *p = new  NODE;
		p->info = x;
		p->pLeft = NULL;
		p->pRight = NULL;//Khoi tao nen node moi chua co lien ket
		t = p;// p la node goc(do la node them vao dau tien)
	}
	else {
		//Neu phan tu them vao nho hon node goc==>>Them vao cay con trai
		if (t->info > x)
			Addnode(t->pLeft, x);//Duyet qua trai them x
		//Truong hop nguoc lai
		else if (t->info < x)
			Addnode(t->pRight, x);
	}
}
//Xuat cay nhi phan theo NLR
void DuyetNLR(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		cout << t->info << " ";// Xuat du lieu
		DuyetNLR(t->pLeft);//duyet qua trai
		DuyetNLR(t->pRight);//duyet qua phai
	}
}
//Xuat cay nhi phan theo NRL
void DuyetNRL(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		cout << t->info << " ";// Xuat du lieu
		DuyetNLR(t->pRight);//duyet qua phai
		DuyetNLR(t->pLeft);//duyet qua trai
	}
}
//Xuat cay nhi phan theo LNR <=>xuat cac phan tu theo trinh tu tang dan(do tinh chat cay nhi phan)
void DuyetLNR(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		DuyetLNR(t->pLeft);//duyet qua trai
		cout << t->info << " ";// Xuat du lieu
		DuyetLNR(t->pRight);//duyet qua phai
		
	}
}
//Xuat cay nhi phan theo RNL<=>xuat cac phan tu theo trinh tu tang dan
void DuyetRNL(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		DuyetRNL(t->pRight);//duyet qua phai
		cout << t->info << " ";// Xuat du lieu
		DuyetRNL(t->pLeft);//duyet qua trai

	}
}
//Xuat cay nhi phan theo LRN
void DuyetLRN(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		DuyetLRN(t->pLeft);//duyet qua trai
		DuyetLRN(t->pRight);//duyet qua phai
		cout << t->info << " ";// Xuat du lieu


	}
}
//Xuat cay nhi phan theo RLN
void DuyetRLN(TREE t) {
	//Cay con phan tu
	if (t != NULL) {
		DuyetRLN(t->pRight);//duyet qua phai
		DuyetRLN(t->pLeft);//duyet qua trai
		cout << t->info << " ";// Xuat du lieu
		

	}
}
void Menu(TREE &t) {
	while (true) {
		system("cls");//Xoa man hinh moi lan chay
		cout << "==========MENU==========" << endl;
		cout << "0.Ket thuc chuong trinh" << endl;
		cout << "1.Nhap du lieu cho cay" << endl;
		cout << "2.Duyet cay theo NLR" << endl;
		cout << "3.Duyet cay theo NRL" << endl;
		cout << "4.Duyet cay theo LNR" << endl;
		cout << "5.Duyet cay theo RNL" << endl;
		cout << "6.Duyet cay theo LRN" << endl;
		cout << "7.Duyet cay theo RLN" << endl;
		cout << "==============================" << endl;
		int lc;
		cout << "Nhap lua chon cua ban:";
		cin >> lc;
		if (lc < 0 || lc>7) {
			cout << "Lua chon khong hop le!" << endl;
			system("pause");
		}
		else {
			switch (lc) {
			case 0: {
				return;
			}
			case 1: {
				int x;
				cout << "Nhap vao x:";
				cin >> x;
				Addnode(t, x);
				break; }
			case 2: {
				cout << "Duyen cay theo NLR:" << endl;
				DuyetNLR(t);
				system("pause");
				break;
			}
			case 3: {
				cout << "Duyen cay theo NRL:" << endl;
				DuyetNRL(t);
				system("pause");
				break;
			}
			case 4: {
				cout << "Duyen cay theo LNR:" << endl;
				DuyetLNR(t);
				system("pause");
				break;
			}
			case 5: {
				cout << "Duyen cay theo RNL:" << endl;
				DuyetRNL(t);
				system("pause");
				break;
			}
			case 6: {
				cout << "Duyen cay theo LRN:" << endl;
				DuyetLRN(t);
				system("pause");
				break;
			}
			case 7: {
				cout << "Duyen cay theo RLN:" << endl;
				DuyetRLN(t);
				system("pause");
				break;
			}
			}
		}
	}
}
void main() {
	TREE t;
	Createtree(t);
	Menu(t);
	system("pause");
}