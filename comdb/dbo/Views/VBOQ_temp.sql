CREATE VIEW dbo.VBOQ_temp
AS
SELECT        dbo.tempTBOQ.ID, dbo.tempTBOQ.CDT, dbo.tempTBOQ.MDT, dbo.tempTBOQ.EDSEQ, dbo.tempTBOQ.BOQTITLE, dbo.tempTBOQ.BOQDESC, dbo.tempTBOQ.CUSTOMERID, dbo.TNAME.NAME AS [CUSTOMER NAME], 
                         dbo.tempTBOQ.BOQDATE, dbo.tempTBOQ.REFNUMBER, dbo.tempTBOQ.ISACTIVE, dbo.tempTBOQ.SITEID, dbo.TSITE.SITENAME, dbo.tempTBOQ.DIVID, dbo.TDIVISION.DIVNAME, dbo.tempTBOQ.VALIDDATE, 
                         dbo.tempTBOQ.TERMSCONDITION, dbo.tempTBOQ.STATUS, dbo.tempTBOQ.UID
FROM            dbo.tempTBOQ LEFT OUTER JOIN
                         dbo.TDIVISION ON dbo.tempTBOQ.DIVID = dbo.TDIVISION.ID LEFT OUTER JOIN
                         dbo.TSITE ON dbo.tempTBOQ.SITEID = dbo.TSITE.ID LEFT OUTER JOIN
                         dbo.TNAME ON dbo.tempTBOQ.CUSTOMERID = dbo.TNAME.ID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tempTBOQ"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 263
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "TDIVISION"
            Begin Extent = 
               Top = 6
               Left = 681
               Bottom = 136
               Right = 851
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "TSITE"
            Begin Extent = 
               Top = 6
               Left = 473
               Bottom = 136
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "TNAME"
            Begin Extent = 
               Top = 6
               Left = 265
               Bottom = 194
               Right = 435
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2025
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VBOQ_temp';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VBOQ_temp';

