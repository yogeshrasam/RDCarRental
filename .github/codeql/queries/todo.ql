/**
 * @name TODO comment
 * @description A comment that contains 'TODO' or similar keywords may indicate code that is incomplete or
 *              broken, or it may highlight an ambiguity in the software's specification.
 * @kind problem
 * @problem.severity recommendation
 * @precision high
 * @id cs/todo-comment
 * @tags maintainability
 */

import csharp

from CommentLine c
where c.getText().regexpMatch("(?s).*FIXME.*|.*TODO.*|.*(?<!=)\\s*XXX.*")
select c, "TODO comments should be addressed."