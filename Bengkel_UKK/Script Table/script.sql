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
	keterangan VARCHAR(100),

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


-- Membuat tabel Booking terlebih dahulu
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
    status VARCHAR(20),
    
    FOREIGN KEY (ktp_pelanggan)
        REFERENCES Pelanggan(ktp_pelanggan)
        ON DELETE SET NULL
        ON UPDATE CASCADE,

    FOREIGN KEY (ktp_mekanik)
        REFERENCES Admins(ktp_admin)
        ON DELETE SET NULL
        ON UPDATE CASCADE
);

-- Membuat tabel BookingSparepart
CREATE TABLE BookingSparepart (
    id_booking INT,
    kode_sparepart VARCHAR(20),
    nama_sparepart VARCHAR(50),
    jumlah INT,
    harga INT,
    image_data VARBINARY(MAX),
    
    CONSTRAINT FK_BookingSparepart_Booking
    FOREIGN KEY (id_booking)
        REFERENCES Booking(id_booking) 
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

DROP TABLE IF EXISTS Riwayat;

CREATE TABLE Riwayat(
    id_riwayat INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    ktp_pelanggan VARCHAR(30),
    nama_pelanggan VARCHAR(100),
    id_kendaraan INT,
    no_pol VARCHAR(30),
    nama_kendaraan VARCHAR(100),
    tanggal DATE,
    tanggal_servis DATETIME,
    tanggal_selesai DATETIME,
    ktp_admin VARCHAR(30),
    ktp_mekanik VARCHAR(30),
    keluhan VARCHAR(100),
    catatan VARCHAR(100),
    total_harga INT,
    id_jasaServis INT,
    status VARCHAR(20),
    pembatalan_oleh VARCHAR(30),
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


-- Tabel RiwayatSparepart
CREATE TABLE RiwayatSparepart(
    id_riwayat INT,
    kode_sparepart VARCHAR(20),
    nama_sparepart VARCHAR(50),
    jumlah INT,
    harga INT,
    image_data VARBINARY(MAX),
    
    FOREIGN KEY (id_riwayat)
        REFERENCES Riwayat(id_riwayat)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

-- Tabel BatasBooking
CREATE TABLE BatasBooking(
    id_batas_booking INT IDENTITY(1,1) PRIMARY KEY,
    tanggal_batas_booking DATETIME, 
    batas_booking INT,
    created_at DATETIME DEFAULT GETDATE()
);

-- Tabel JadwalLibur
CREATE TABLE JadwalLibur(
    id_jadwal_libur INT PRIMARY KEY IDENTITY (1,1),
    tanggal DATETIME,
    hari VARCHAR(50)
);

-- Tabel JadwalOperasional
CREATE TABLE JadwalOperasional(
    id_jadwal_operasional INT PRIMARY KEY IDENTITY (1,1),
    hari VARCHAR(50),
    jam_buka TIME,
    jam_tutup TIME
);


-- Tambah Pelanggan
INSERT INTO Pelanggan (ktp_pelanggan, nama_pelanggan, email, password, alamat, no_telp)
VALUES 
('123456789', 'Budi Santoso', 'budi@email.com', 'password123', 'Jl. Merdeka No.10', '081234567890');

-- Tambah Admin (Sebagai Mekanik)
INSERT INTO Admin (ktp_admin, nama_admin, email, password, alamat, no_telp, role)
VALUES 
('987654321', 'Mekanik Andi', 'andi@email.com', 'password456', 'Jl. Kemerdekaan No.20', '082345678901', 1);

-- Tambah Kendaraan
INSERT INTO Kendaraan (no_pol, merk, tipe, transmisi, kapasitas, tahun, ktp_pelanggan, total_servis)
VALUES 
('B 1234 ABC', 'Toyota', 'Avanza', 'Manual', 7, '2020', '123456789', 0);

-- Tambah Jasa Servis
INSERT INTO JasaServis (nama_jasaServis, harga, keterangan)
VALUES 
('Ganti Oli', 150000, 'Paket servis ganti oli');

-- Tambah Sparepart
INSERT INTO Sparepart (kode_sparepart, nama_sparepart, stok, stok_minimum, harga)
VALUES 
('SP001', 'Oli Mesin', 50, 5, 75000);

-- Tambah Booking
INSERT INTO Booking (ktp_pelanggan, id_kendaraan, tanggal, keluhan, id_jasaServis, status)
VALUES 
('123456789', 1, '2025-03-10', 'Rem berbunyi keras', 1, 'Menunggu');


-- comit rollback

BEGIN TRANSACTION;

BEGIN TRY
    -- Tambah data riwayat servis
    INSERT INTO Riwayat (ktp_pelanggan, nama_pelanggan, id_kendaraan, no_pol, tanggal, total_harga, status)
    VALUES ('123456789', 'Budi Santoso', 1, 'B 1234 ABC', GETDATE(), 500000, 'Selesai');

    -- Simulasi kesalahan dengan memasukkan kendaraan yang tidak ada
    INSERT INTO Riwayat (ktp_pelanggan, nama_pelanggan, id_kendaraan, no_pol, tanggal, total_harga, status)
    VALUES ('987654321', 'Andi Wijaya', 999, 'B 9999 XYZ', GETDATE(), 700000, 'Selesai');

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT 'Terjadi kesalahan, transaksi dibatalkan.';
END CATCH;


-- procedure
go;

CREATE PROCEDURE AddBooking 
    @ktp_pelanggan VARCHAR(30),
    @id_kendaraan INT,
    @tanggal DATE,
    @keluhan VARCHAR(100),
    @id_jasaServis INT
AS
BEGIN
    INSERT INTO Booking (ktp_pelanggan, id_kendaraan, tanggal, keluhan, id_jasaServis, status)
    VALUES (@ktp_pelanggan, @id_kendaraan, @tanggal, @keluhan, @id_jasaServis, 'Menunggu');
END;


EXEC AddBooking '123456789', 1, '2025-03-10', 'Rem berbunyi keras', 2;


go; 
-- Trigger

CREATE TRIGGER trg_UpdateStokSparepart
ON BookingSparepart
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
        
    UPDATE Sparepart
    SET stok = stok - i.jumlah
    FROM Sparepart s
    INNER JOIN inserted i ON s.kode_sparepart = i.kode_sparepart
    WHERE s.stok >= i.jumlah;
END;

go;

CREATE TRIGGER trg_AdjustStokSparepart
ON BookingSparepart
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Mengembalikan stok sparepart sesuai jumlah sebelum update
    UPDATE Sparepart
    SET stok = stok + d.jumlah
    FROM Sparepart s
    INNER JOIN deleted d ON s.kode_sparepart = d.kode_sparepart;

    -- Mengurangi stok sparepart sesuai jumlah baru setelah update
    UPDATE Sparepart
    SET stok = stok - i.jumlah
    FROM Sparepart s
    INNER JOIN inserted i ON s.kode_sparepart = i.kode_sparepart
    WHERE s.stok >= i.jumlah;
END;

go;

CREATE TRIGGER trg_RestoreStokSparepart
ON BookingSparepart
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Mengembalikan stok sparepart saat data dihapus
    UPDATE Sparepart
    SET stok = stok + d.jumlah
    FROM Sparepart s
    INNER JOIN deleted d ON s.kode_sparepart = d.kode_sparepart;
END;



-- join

SELECT 
    b.id_booking, 
    p.nama_pelanggan, 
    k.no_pol, 
    k.merk, 
    k.tipe, 
    b.tanggal, 
    b.status
FROM Booking b
INNER JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
INNER JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan
WHERE b.status = 'Menunggu';

SELECT 
    b.id_booking, 
    p.nama_pelanggan, 
    k.no_pol, 
    k.merk, 
    k.tipe, 
    b.tanggal, 
    b.status
FROM Booking b
LEFT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
LEFT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan;

SELECT 
    b.id_booking, 
    p.nama_pelanggan, 
    k.no_pol, 
    k.merk, 
    k.tipe, 
    b.tanggal, 
    b.status
FROM Booking b
RIGHT JOIN Pelanggan p ON b.ktp_pelanggan = p.ktp_pelanggan
RIGHT JOIN Kendaraan k ON b.id_kendaraan = k.id_kendaraan;

go; 


--  function

CREATE FUNCTION GetTotalServis(@ktp_pelanggan VARCHAR(30))
RETURNS INT
AS
BEGIN
    DECLARE @TotalServis INT;
    SELECT @TotalServis = COUNT(*) FROM Riwayat WHERE ktp_pelanggan = @ktp_pelanggan;
    RETURN @TotalServis;
END;

go;

SELECT nama_pelanggan, dbo.GetTotalServis(ktp_pelanggan) AS TotalServis
FROM Pelanggan;


