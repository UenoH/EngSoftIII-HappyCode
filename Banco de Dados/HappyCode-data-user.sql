USE DATABASE [HappyCode]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
INSERT [dbo].[Usuario] ([Id_Usuario], [Id_Professor], [Tx_Nome], [Tx_Login], [Tx_Senha], [St_Admin], [St_Ativo]) VALUES (1, 0, N'Administrador', N'admin', N'u0IbCWAhxd82qmbzotME3w==', 1, 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
