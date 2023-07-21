nilnul.bit Library

(codename: nilnul.\_bit_.\_LIB_)

A library for boolean(true false), includes operators, expressions, proofs, and more.
This doesnot deal with quantifiers such as "ForAll" or "Existing"; quantifiers would be dealt with in another subsequent project: nilnul.logic.

Keywords: boolean algebra.

# Source Code

The unit testing project is placed in another repository; the testing project shall be placed under a common parent folder(we call this folder as nilnul.bit solution) of this project. Open the solution under the testing project, and the testing project would reference this library project as a raw source code project refeence within a same solution. 

Unit testing includes not only many verification tests, but also trials that you can use to do some computation (eg, to investigate an idea) directly rather than create a seprate console or other application.

# Compiled Package

The package is pushed to nuget.org under the code name. The package's version is in the following format:

	major.minor.date.time

where

	date, for example:230722, is in yymmdd format, 
	time, for example: 200220, is in hhMMss format.

So you can always tell from the package version of the datetime of this package.

Currently, the version is appended with "-sym", so please make sure to check "including Previews" to search for it from nuget.org.

When the unit testing covers all code paths, the version will be changed to a "Release".

The ".dll" in this package is versioned the same across different package versions, given the major part of the version doesnot change. This will not incur the "dll hell" problem; if the version of ".dll" didnot match exactly, in windows form control designer or possibly in other scenarios, a problem might arise.

To keep the ".dll" version constant, we will make no break changes. APIs might be obsoleted, but never deleted, given the same major part of version.

We'll, in the forseeable future, keep the major part of the version unchanged.

# Implemented

The library deals with boolean (in other words, bit) values: false, true.

Operators are defined under these namespaces:

0) nilnul.bit.op_.nary_  for 0-arity operators; 
	
we have two such operators: true, false. This is theoretically significant both aesthetically and practically, in that by including only operators, we can define abstract algebra (see in this library: nilnul.bit.abgebra_), and we can define expressions (see: nilnul.bit.expr_ in this lib)

1) nilnul.bit.op_.unary_ for unary operators.

we have four such operator, including:

	not
	x -> x, which is called identity or noop operator

2) nilnul.bit.op_.binary_ for binary operators:
 
we have 16 such operators, including:

	and
	or
	xor
	imply
	equiv (biimply)

Expressions are defined under namespace: nilnul.bit.expr_, where nilnul.bit.expr_.IVar is a bit variable. We can use nilnul.bit.Expr to represent bit expressions such as:
	
	x&y

Here you can compute the truth table of an expression by using nilnul.bit.expr_.capsule.to_.\_CalibrateX. If you can get the truth table, you can transform an expression to canonical form (nilnul.bit.expr_.closed_.ICanonic).

3) nilnul.bit.abgebra_ for abstract algebra of bits:

Here we organized some concepts which can help grasp the essence of bit algebra and help you understand some thinkings, which guarantine the correctness of some algorithms|solutions, and avoid some pitfalls. For example, nilnul.bit.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_.eg_.Xor9and, where "9" means "and" or "with", is a ring with operators {Xor, And}. This helps establish the concept of nilnul.bit.expr_.closed_.abgebra_.ringy_.IXor9and, a.k.a., Algebraic Normal form.

# Some Highlights

To determine whether a set of operators is complete or not, we can use: 
nilnul.bit.of_.vec.set.be_.Complete.

We also have a corresponding unit test for it, whether you can verify some frequently mentioned sets of operators are complete or not. For example:

{1,xor, and} is complete, while {xor, and} is not.

In unit testing project: nilnul.\_bit_.\_TEST_.algebra_.cobiops.be_.semi.commaed.UnitTest1
 can list the properties of all abstract algebra with two opertors, where we can understand why, in our lib project, we have only two abstract algebra rings:

	nilnul.bit.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_.eg_.Xor9and
	nilnul.bit.abgebra_.cobiop_.grp4add_.monoid4mul_.ring_.eg_.Eq9or

Proof theory is also under implemention in this project, under the namespace nilnul.bit.proof as well others. 

# Coding Style

The naming follows nilnul dev style, which will be detailed later in other projects, such as:

	nilnul.txt_.vered_.id  in project: "nilnul._txt_._LIB_"
	nilnul.dev._src_._LIB_ 

for a brief idea. The style is currently relative stable, consisitent and inclusive, but hasnot been well documented. But to read the code of nilnul project, you may find over time that they all follow the same style.


# License
Please view the license file under the base folder of each project.







