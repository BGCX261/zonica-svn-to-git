-- �lbumes mas escuchados por us usuario
SELECT TOP 10
    COUNT(e.id_temaMusical) Ranking,
    al.Nombre NombreAlbum,
    ar.Nombre NombreArtista
FROM
    Zonica.dbo.Escucha e,
    Zonica.dbo.Artista ar,
    Zonica.dbo.Album al,
    Zonica.dbo.TemaMusical tm
WHERE
    e.id_temaMusical = tm.id
    AND tm.id_album = al.id
    AND al.id_artista = ar.id
    AND e.id_perfilUsuario = :perfilUsuario
GROUP BY
    al.Nombre,
    ar.Nombre
ORDER BY
    Ranking DESC