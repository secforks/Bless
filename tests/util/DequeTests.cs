// created on 7/4/2005 at 12:38 PM
/*
 *   Copyright (c) 2005, Alexandros Frantzis (alf82 [at] freemail [dot] gr)
 *
 *   This file is part of Bless.
 *
 *   Bless is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 *   Bless is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with Bless; if not, write to the Free Software
 *   Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
using NUnit.Framework;
using System;

using Bless.Util;

namespace BlessTests.Util {

[TestFixture]
public class DequeTests {


	[Test]
	public void CountTest()
	{
		Deque d = new Deque();
		d.AddFront(4);
		d.AddFront(5);
		d.AddFront(6);
		d.AddFront(7);

		Assert.AreEqual(4, d.Count);
	}

	[Test]
	public void RemoveEndTest()
	{
		Deque d = new Deque();
		d.AddFront(4);
		d.AddFront(5);
		d.AddFront(6);
		d.AddFront(7);

		Assert.AreEqual(4, (int)d.RemoveEnd());
		Assert.AreEqual(5, (int)d.RemoveEnd());
		Assert.AreEqual(6, (int)d.RemoveEnd());
		Assert.AreEqual(7, (int)d.RemoveEnd());
	}

	[Test]
	public void RemoveFrontTest()
	{
		Deque d = new Deque();
		d.AddFront(4);
		d.AddFront(5);
		d.AddFront(6);
		d.AddFront(7);

		Assert.AreEqual(7, (int)d.RemoveFront());
		Assert.AreEqual(6, (int)d.RemoveFront());
		Assert.AreEqual(5, (int)d.RemoveFront());
		Assert.AreEqual(4, (int)d.RemoveFront());
	}




	[Test]
	public void MixedTest()
	{
		Deque d = new Deque();
		d.AddFront(5);
		d.AddEnd(6);
		d.AddFront(4);
		d.AddEnd(7);

		Assert.AreEqual(7, (int)d.RemoveEnd());
		Assert.AreEqual(4, (int)d.RemoveFront());
		Assert.AreEqual(6, (int)d.RemoveEnd());
		Assert.AreEqual(5, (int)d.RemoveFront());
	}

	[Test]
	public void PeekTest()
	{
		Deque d = new Deque();

		d.AddEnd(4);
		d.AddEnd(5);
		d.AddEnd(6);
		d.AddEnd(7);

		Assert.AreEqual(7, (int)d.PeekEnd());
		Assert.AreEqual(7, (int)d.PeekEnd());
		Assert.AreEqual(4, (int)d.PeekFront());
		Assert.AreEqual(4, (int)d.PeekFront());
		d.RemoveEnd();
		Assert.AreEqual(6, (int)d.PeekEnd());
		d.RemoveFront();
		Assert.AreEqual(5, (int)d.PeekFront());
	}

	[Test]
	public void ClearTest()
	{
		Deque d = new Deque();

		d.AddEnd(4);
		d.AddEnd(5);
		d.AddEnd(6);
		d.AddEnd(7);

		Assert.AreEqual(7, (int)d.PeekEnd());
		Assert.AreEqual(4, (int)d.PeekFront());

		d.Clear();
		Assert.AreEqual(0, d.Count);
	}

	[Test]
	public void NullTest()
	{
		Deque d = new Deque();

		Assert.IsNull(d.RemoveFront());

		d.AddEnd(1);
		Assert.AreEqual(1, (int)d.RemoveEnd());
		Assert.IsNull(d.RemoveEnd());

		d.AddFront(2);
		Assert.AreEqual(2, (int)d.RemoveFront());
		Assert.IsNull(d.RemoveFront());

	}

}

} // end namespace
