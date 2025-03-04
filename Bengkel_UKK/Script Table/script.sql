CREATE TABLE Sparepart(
	kode_sparepart VARCHAR(20) NOT NULL PRIMARY KEY,
	nama_sparepart VARCHAR(50),
	stok INT,
	stok_minimum INT,
	harga INT,
	image_data VARBINARY(MAX),

	created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
	);

CREATE TABLE Pelanggan(
	ktp_pelanggan VARCHAR(30) NOT NULL PRIMARY KEY,
	nama_pelanggan VARCHAR(100),
	email VARCHAR(50),
	password VARCHAR(50),
	alamat VARCHAR(100),
	no_telp VARCHAR(20),

	created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
	);

CREATE TABLE Admin(
	ktp_admin VARCHAR(30) NOT NULL PRIMARY KEY,
	nama_admin VARCHAR(100),
	email VARCHAR(50),
	password VARCHAR(50),
	alamat VARCHAR(100),
	no_telp VARCHAR(20),
	role INT,
	image_data VARBINARY(MAX),

	created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
);

CREATE TABLE JasaServis(
	id_jasaServis INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nama_jasaServis VARCHAR(100),
	harga INT,

	created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL
	);


CREATE TABLE Kendaraan(
	id_kendaraan INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	no_pol VARCHAR(30),
	merk VARCHAR(20),
	tipe VARCHAR(20),
	transmisi VARCHAR(20),
	kapasitas INT,
	tahun VARCHAR(5),
	ktp_pelanggan VARCHAR(30),
	total_servis INT,
	created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    deleted_at DATETIME NULL,
	FOREIGN KEY (ktp_pelanggan)
		REFERENCES Pelanggan(ktp_pelanggan)
		ON DELETE CASCADE
		ON UPDATE CASCADE
	);


CREATE TABLE Booking(
	id_booking INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ktp_pelanggan VARCHAR(30),
	nama_pelanggan VARCHAR(100),
	id_kendaraan INT,
	no_pol VARCHAR(30),
	nama_kendaraan VARCHAR(100),
	tanggal DATE,
	keluhan VARCHAR(100),

	catatan VARCHAR(100),
	antrean INT,
	tipe_antrean INT,
	ktp_mekanik VARCHAR(30),
	id_jasaServis INT,
	status VARCHAR(20)
	FOREIGN KEY (ktp_pelanggan)
		REFERENCES Pelanggan(ktp_pelanggan)
		ON DELETE SET NULL
		ON UPDATE CASCADE,
	FOREIGN KEY (ktp_mekanik)
		REFERENCES Admins(ktp_admin)
		ON DELETE SET NULL
		ON UPDATE CASCADE
	);


CREATE TABLE BookingSparepart(
	id_booking INT,
	kode_sparepart VARCHAR(20),
	nama_sparepart VARCHAR(50),
	jumlah INT,
	harga INT,
	image_data VARBINARY(MAX)

	FOREIGN KEY (id_booking)
		REFERENCES Bookings(id_booking)
		ON DELETE CASCADE
		ON UPDATE CASCADE
        );

CREATE TABLE Riwayat(
    id_riwayat INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ktp_pelanggan VARCHAR(30),
    nama_pelanggan VARCHAR(100),
    id_kendaraan INT,
    no_pol VARCHAR(30),
    nama_kendaraan VARCHAR(100),
    tanggal DATE,
    ktp_admin VARCHAR(30),
    ktp_mekanik VARCHAR(30),
    keluhan VARCHAR(100),
    catatan VARCHAR(100),
    total_harga INT,
    id_jasaServis INT,
    status VARCHAR(20),
	created_at DATETIME DEFAULT GETDATE(),
                        
	FOREIGN KEY (ktp_pelanggan)
		REFERENCES Pelanggan(ktp_pelanggan),
	FOREIGN KEY (id_kendaraan)
		REFERENCES Kendaraan(id_kendaraan)
		ON DELETE SET NULL
		ON UPDATE CASCADE,
	FOREIGN KEY (ktp_admin)
		REFERENCES Admins(ktp_admin)
		ON DELETE CASCADE
		ON UPDATE CASCADE
);



CREATE TABLE RiwayatSparepart(
	id_riwayat INT,
	kode_sparepart VARCHAR(20),
	nama_sparepart VARCHAR(50),
	jumlah INT,
	harga INT,
	image_data VARBINARY(MAX)

	FOREIGN KEY (id_riwayat)
		REFERENCES Riwayat(id_riwayat)
		ON DELETE CASCADE
		ON UPDATE CASCADE
        );

CREATE TABLE BatasBooking(
    id_batas_booking INT IDENTITY(1,1) PRIMARY KEY,
    tanggal DATETIME,
    batas_booking INT,
    created_at DATETIME DEFAULT GETDATE()
);

DROP TABLE JadwalLibur;
CREATE TABLE JadwalLibur(
	id_jadwal_libur INT PRIMARY KEY IDENTITY (1,1),
	tanggal DATETIME,
	hari VARCHAR(50)
);

CREATE TABLE JadwalOperasional(
	id_jadwal_operasional INT PRIMARY KEY IDENTITY (1,1),
	hari VARCHAR(50),
	jam_buka TIME,
	jam_tutup TIME
);
