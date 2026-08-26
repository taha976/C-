#include <iostream>
#include <vector>
#include <string>

using namespace std;

// --- Sınıf Tanımı ---
class Ag_Paketi {
private:
    string kaynak_Ip;
    int hedef_port{};
    int tehdit_Seviyesi{};

public:
    // Constructor (Yapıcı Metot): Verileri nesne oluşurken içeri kilitler
    Ag_Paketi(string ip, int port, int seviye) {
        kaynak_Ip = ip;
        hedef_port = port;
        tehdit_Seviyesi = seviye;
    }

    // Bilgileri Ekrana Yazdıran Metot (Void)
    void bilgi_göster() {
        cout << "[LOG] IP: " << kaynak_Ip 
             << " | Port: " << hedef_port 
             << " | Tehdit: " << tehdit_Seviyesi << endl;
    }
};

// --- Ana Program ---
int main() {
    int port, seviye;
    string ip;
    vector<Ag_Paketi> paketListesi; // Dinamik kayıt defterimiz

    while (true) {
        cout << "\n--- Yeni Paket Girişi ---" << endl;
        cout << "Kaynak IP giriniz: ";
        cin >> ip;
        cout << "Hedef port giriniz: ";
        cin >> port;
        cout << "Tehdit seviyesi (0-100) giriniz: ";
        cin >> seviye;

        // Nesne oluşturma ve listeye ekleme
        Ag_Paketi yeni_paket(ip, port, seviye);
        paketListesi.push_back(yeni_paket);

        // Anlık doğrulama
        yeni_paket.bilgi_göster();

        // Döngü kontrolü (Break mekanizması)
        char secim;
        cout << "\nBaska bir paket taramak istiyor musunuz? (e/h): ";
        cin >> secim;
        
        if (secim == 'h' || secim == 'H') {
            cout << "\nGiris sonlandirildi. Kayitlar dokuluyor...\n" << endl;
            break; 
        }
    }

    // --- Final Raporu ---
    cout << "========== TUM TARAMA KAYITLARI ==========" << endl;
    for (int i = 0; i < paketListesi.size(); i++) {
        cout << i + 1 << ". Kayit -> ";
        paketListesi[i].bilgi_göster();
    }
    cout << "==========================================" << endl;

    return 0;
}