SELECT
	p.product_name,
        c.category_name
FROM  
	products p
LEFT JOIN 
	correspondence_categories_and_products cpac ON  p.id = cpac.product_id
LEFT JOIN
	categories c ON cpac.category_id = c.id;
