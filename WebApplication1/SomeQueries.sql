declare @slug varchar(30) = 'life-of-pi';

select a.Name --, a.Slug
from Books b
	join BooksAuthors ba on b.Id = ba.BookId
	join Authors a on ba.AuthorId = a.Id
where Slug = @slug

select count(*), avg(r.Rank)
from Reviews r
	join Books b on r.BookId = b.Id
where b.Slug = @slug

select top 10 b.Title, avg(r.rank)
from Books b
	join Reviews r on b.Id = r.BookId
group by b.Title
having avg(r.rank) > 7
order by 2 desc