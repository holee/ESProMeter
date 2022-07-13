CREATE VIEW dbo.VQUOTE
AS
SELECT        dbo.TQUOTE.REFNUMBER, dbo.TQUOTE.QUOTEDATE, dbo.TBOQ.ID AS BOQID, dbo.TNAME.NAME, dbo.TSITE.SITENAME, dbo.TDIVISION.DIVNAME, dbo.TQUOTE.VALIDDATE, dbo.TQUOTE.TERMSCONDITION, 
                         dbo.TQUOTE.TOTALAMOUNT, dbo.TQUOTE.ISACTIVE, dbo.TQUOTE.ID
FROM            dbo.TQUOTE LEFT OUTER JOIN
                         dbo.TDIVISION ON dbo.TQUOTE.DIVID = dbo.TDIVISION.ID LEFT OUTER JOIN
                         dbo.TSITE ON dbo.TQUOTE.SITEID = dbo.TSITE.ID LEFT OUTER JOIN
                         dbo.TNAME ON dbo.TQUOTE.CUSTOMERID = dbo.TNAME.ID LEFT OUTER JOIN
                         dbo.TBOQ ON dbo.TQUOTE.BOQID = dbo.TBOQ.ID

GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[57] 4[15] 2[17] 3) )"
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
         Begin Table = "TQUOTE"
            Begin Extent = 
               Top = 0
               Left = 38
               Bottom = 298
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "TBOQ"
            Begin Extent = 
               Top = 6
               Left = 265
               Bottom = 288
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TNAME"
            Begin Extent = 
               Top = 6
               Left = 492
               Bottom = 269
               Right = 662
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TSITE"
            Begin Extent = 
               Top = 6
               Left = 700
               Bottom = 223
               Right = 870
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TDIVISION"
            Begin Extent = 
               Top = 20
               Left = 889
               Bottom = 209
               Right = 1059
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
         Column = 1440
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
      ', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VQUOTE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VQUOTE';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'VQUOTE';

