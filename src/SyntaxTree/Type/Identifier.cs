// Copyright (C) 2016  Simon Mika <simon@mika.se>
//
// This file is part of SysPL.
//
// SysPL is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// SysPL is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with SysPL.  If not, see <http://www.gnu.org/licenses/>.
//

namespace SysPL.SyntaxTree.Type
{
	public class Identifier : Expression
	{
		public override int Precedence { get { return 50; } }
		public string Name { get; }
		public Identifier(string name)
		{
			this.Name = name;
		}
		public override bool Equals(Expression other)
		{
			return other is Identifier && this.Name == ((Identifier)other).Name;
		}
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}
		public override string ToString()
		{
			return this.Name;
		}
	}
}
