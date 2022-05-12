
create table DM_VATTU(
MA_DVIQLY VARCHAR(255),
ID_VT_ERP INT,
MA_VT_ERP VARCHAR(255),
TEN_VT_ERP NVARCHAR(255),
DVT_ERP NVARCHAR(255),
SO_PHA INT,
TRANG_THAI INT,
PRIMARY KEY (ID_VT_ERP)
)

create table DM_CPHI_VANCHUYEN(
MA_DVIQLY VARCHAR(255),
MA_CPHI_VCHUYEN VARCHAR(255),
TEN_CPHI_VCHUYEN NVARCHAR(255),
DON_GIA INT,
HE_SO FLOAT,
NGUOI_TAO VARCHAR(255),
NGUOI_SUA VARCHAR(255),
NGAY_TAO DATE,
NGAY_SUA DATE,
TRANG_THAI INT,
PRIMARY KEY (MA_CPHI_VCHUYEN)
)

create table DM_CPHI_NHANCONG(
MA_DVIQLY VARCHAR(255),
MA_HIEU VARCHAR(255),
TEN_CONG_VIEC NVARCHAR(255),
DVT NVARCHAR(255),
DON_GIA_NC INT,
DON_GIA_MAY_TC INT,
TRANG_THAI INT,
NGAY_TAO DATE,
NGUOI_TAO NVARCHAR(255),
NGAY_SUA DATE,
NGUOI_SUA NVARCHAR(255),
SO_PHA INT,
ID INT,
HE_SO_NC FLOAT,
HE_SO_MAY_TC FLOAT,
DON_GIA_VLP INT,
PRIMARY KEY (ID)
)

create table DM_CPHI_KHAOSAT(
MA_DVIQLY VARCHAR(255),
MA_CPHI_KSAT VARCHAR(255),
TEN_CPHI_KSAT NVARCHAR(255),
DVT NVARCHAR(255),
CPHI_KSAT INT,
HE_SO_KSAT FLOAT,
NGUOI_TAO VARCHAR(255),
NGUOI_SUA VARCHAR(255),
NGAY_TAO DATE,
NGAY_SUA DATE,
TRANG_THAI INT,
PRIMARY KEY (MA_CPHI_KSAT)
)

drop table DM_VATTU
drop table DM_CPHI_NHANCONG
drop table DM_CPHI_KHAOSAT
drop table DM_CPHI_VANCHUYEN

INSERT INTO DM_VATTU (MA_DVIQLY, ID_VT_ERP, MA_VT_ERP, TEN_VT_ERP, DVT_ERP, SO_PHA, TRANG_THAI)
VALUES 
('DVIQLY_001', 1, 'VT_ERP_001', 'Cáp quang 1', 'm', 4, 1),
('DVIQLY_002', 2, 'VT_ERP_002', 'Cáp quang 2', 'm', 4, 1),
('DVIQLY_003', 3, 'VT_ERP_003', 'Cáp quang 3', 'm', 4, 1),
('DVIQLY_004', 4, 'VT_ERP_004', 'Cáp quang 4', 'm', 4, 1),
('DVIQLY_005', 5, 'VT_ERP_005', 'Cáp quang 5', 'm', 4, 1),
('DVIQLY_006', 6, 'VT_ERP_006', 'Cáp quang 6', 'm', 4, 1),
('DVIQLY_007', 7, 'VT_ERP_007', 'Cáp quang 7', 'm', 4, 1),
('DVIQLY_008', 8, 'VT_ERP_008', 'Cáp quang 8', 'm', 4, 1),
('DVIQLY_009', 9, 'VT_ERP_009', 'Cáp quang 9', 'm', 4, 1),
('DVIQLY_010', 10, 'VT_ERP_010', 'Cáp quang 10', 'm', 4, 1);

INSERT INTO DM_CPHI_VANCHUYEN (MA_DVIQLY, MA_CPHI_VCHUYEN, TEN_CPHI_VCHUYEN, DON_GIA, HE_SO, NGUOI_TAO, NGUOI_SUA, NGAY_TAO, NGAY_SUA, TRANG_THAI)
VALUES 
('DVIQLY_001', 'CPVC001', 'Vận chuyển cáp quang 1', 100000, 1.5, 'Trần Văn A', ' Nguyễn Thị A', '2022-03-10', '2022-03-20', 1),
('DVIQLY_002', 'CPVC002', 'Vận chuyển cáp quang 2', 110000, 1.5, 'Trần Văn B', ' Nguyễn Thị B', '2022-03-10', '2022-03-20', 1),
('DVIQLY_003', 'CPVC003', 'Vận chuyển cáp quang 3', 120000, 1.5, 'Trần Văn C', ' Nguyễn Thị C', '2022-03-10', '2022-03-20', 1),
('DVIQLY_004', 'CPVC004', 'Vận chuyển cáp quang 4', 130000, 1.5, 'Trần Văn D', ' Nguyễn Thị D', '2022-03-10', '2022-03-20', 1),
('DVIQLY_005', 'CPVC005', 'Vận chuyển cáp quang 5', 140000, 1.5, 'Trần Văn E', ' Nguyễn Thị E', '2022-03-10', '2022-03-20', 1),
('DVIQLY_006', 'CPVC006', 'Vận chuyển cáp quang 6', 150000, 1.5, 'Trần Văn F', ' Nguyễn Thị F', '2022-03-10', '2022-03-20', 1),
('DVIQLY_007', 'CPVC007', 'Vận chuyển cáp quang 7', 160000, 1.5, 'Trần Văn G', ' Nguyễn Thị G', '2022-03-10', '2022-03-20', 1),
('DVIQLY_008', 'CPVC008', 'Vận chuyển cáp quang 8', 170000, 1.5, 'Trần Văn H', ' Nguyễn Thị H', '2022-03-10', '2022-03-20', 1),
('DVIQLY_009', 'CPVC009', 'Vận chuyển cáp quang 9', 180000, 1.5, 'Trần Văn I', ' Nguyễn Thị I', '2022-03-10', '2022-03-20', 1),
('DVIQLY_010', 'CPVC010', 'Vận chuyển cáp quang 10', 200000, 1.5, 'Trần Văn J', ' Nguyễn Thị J', '2022-03-10', '2022-03-20', 1);

INSERT INTO DM_CPHI_NHANCONG (MA_DVIQLY, MA_HIEU, TEN_CONG_VIEC, DVT, DON_GIA_NC, DON_GIA_MAY_TC, TRANG_THAI, NGAY_TAO, NGUOI_TAO, NGAY_SUA, NGUOI_SUA, SO_PHA, ID, HE_SO_NC, HE_SO_MAY_TC, DON_GIA_VLP)
VALUES
('DVIQLY_001', 'H001', 'Công việc 1', 'm', 110000, 110000, 1, '2022-03-10', 'Trần Văn A', '2022-03-20', 'Nguyễn Thị A', 4, 1, 1.5, 1.5, 110000),
('DVIQLY_002', 'H002', 'Công việc 2', 'm', 120000, 120000, 1, '2022-03-10', 'Trần Văn B', '2022-03-20', 'Nguyễn Thị B', 4, 2, 1.5, 1.5, 120000),
('DVIQLY_003', 'H003', 'Công việc 3', 'm', 130000, 130000, 1, '2022-03-10', 'Trần Văn C', '2022-03-20', 'Nguyễn Thị C', 4, 3, 1.5, 1.5, 130000),
('DVIQLY_004', 'H004', 'Công việc 4', 'm', 140000, 140000, 1, '2022-03-10', 'Trần Văn D', '2022-03-20', 'Nguyễn Thị D', 4, 4, 1.5, 1.5, 140000),
('DVIQLY_005', 'H005', 'Công việc 5', 'm', 150000, 150000, 1, '2022-03-10', 'Trần Văn E', '2022-03-20', 'Nguyễn Thị E', 4, 5, 1.5, 1.5, 150000),
('DVIQLY_006', 'H006', 'Công việc 6', 'm', 160000, 160000, 1, '2022-03-10', 'Trần Văn F', '2022-03-20', 'Nguyễn Thị F', 4, 6, 1.5, 1.5, 160000),
('DVIQLY_007', 'H007', 'Công việc 7', 'm', 170000, 170000, 1, '2022-03-10', 'Trần Văn G', '2022-03-20', 'Nguyễn Thị G', 4, 7, 1.5, 1.5, 170000),
('DVIQLY_008', 'H008', 'Công việc 8', 'm', 180000, 180000, 1, '2022-03-10', 'Trần Văn H', '2022-03-20', 'Nguyễn Thị H', 4, 8, 1.5, 1.5, 180000),
('DVIQLY_009', 'H009', 'Công việc 9', 'm', 190000, 190000, 1, '2022-03-10', 'Trần Văn I', '2022-03-20', 'Nguyễn Thị I', 4, 9, 1.5, 1.5, 190000),
('DVIQLY_010', 'H010', 'Công việc 10', 'm', 200000, 200000, 1, '2022-03-10', 'Trần Văn J', '2022-03-20', 'Nguyễn Thị J', 4, 10, 1.5, 1.5, 200000);

INSERT INTO DM_CPHI_KHAOSAT (MA_DVIQLY, MA_CPHI_KSAT, TEN_CPHI_KSAT, DVT, CPHI_KSAT, HE_SO_KSAT, NGUOI_TAO, NGUOI_SUA, NGAY_TAO, NGAY_SUA, TRANG_THAI)
VALUES
('DVIQLY001', 'CPKS001', 'Khảo sát 1', 'm', 110000, 1.5, 'Trần Văn A', 'Nguyễn Thị A', '2022-03-10', '2022-04-20', 1),
('DVIQLY002', 'CPKS002', 'Khảo sát 2', 'm', 120000, 1.5, 'Trần Văn B', 'Nguyễn Thị B', '2022-03-10', '2022-04-20', 1),
('DVIQLY003', 'CPKS003', 'Khảo sát 3', 'm', 130000, 1.5, 'Trần Văn C', 'Nguyễn Thị C', '2022-03-10', '2022-04-20', 1),
('DVIQLY004', 'CPKS004', 'Khảo sát 4', 'm', 140000, 1.5, 'Trần Văn D', 'Nguyễn Thị D', '2022-03-10', '2022-04-20', 1),
('DVIQLY005', 'CPKS005', 'Khảo sát 5', 'm', 150000, 1.5, 'Trần Văn E', 'Nguyễn Thị E', '2022-03-10', '2022-04-20', 1),
('DVIQLY006', 'CPKS006', 'Khảo sát 6', 'm', 160000, 1.5, 'Trần Văn F', 'Nguyễn Thị F', '2022-03-10', '2022-04-20', 1),
('DVIQLY007', 'CPKS007', 'Khảo sát 7', 'm', 170000, 1.5, 'Trần Văn G', 'Nguyễn Thị G', '2022-03-10', '2022-04-20', 1),
('DVIQLY008', 'CPKS008', 'Khảo sát 8', 'm', 180000, 1.5, 'Trần Văn H', 'Nguyễn Thị H', '2022-03-10', '2022-04-20', 1),
('DVIQLY009', 'CPKS009', 'Khảo sát 9', 'm', 190000, 1.5, 'Trần Văn I', 'Nguyễn Thị I', '2022-03-10', '2022-04-20', 1),
('DVIQLY010', 'CPKS010', 'Khảo sát 10', 'm', 200000, 1.5, 'Trần Văn J', 'Nguyễn Thị J', '2022-03-10', '2022-04-20', 1);



SELECT * FROM DM_VATTU
SELECT * FROM DM_CPHI_KHAOSAT
SELECT * FROM DM_CPHI_VANCHUYEN
SELECT * FROM DM_CPHI_NHANCONG