<p>I'm trying to learn C#/MonoGame by coding short demos in a number of genres/styles, ideally in increasing complexity. This is my attempt at a (very) short demo for a Gradius-inspired horizontal shooter.</p>
<p><img src="https://github.com/defaultroot1/SideScrollShooter/blob/master/Screenshot/screen1.png" alt="" /></p>
<p>Although the demo plays pretty cleanly, the quality of the code deteriorated rapidly as I progressed. I was referencing a few tutorials that made much more use of public static classes and globals than I had previously tried, along with some new concepts I wasn't familiar with, with the result being an inconsistent mess. It also resulted in increasing complexity to add new features, as I found for each new feature I was having to go back to update/fix base classes or put in hacky workarounds. Even though I wanted to add some additional features found in the opening of Gradius (foreground surface sprite, turrets, player power-ups, ground-hugging missiles etc.), it wasn't worth continuing in the current state, so the result is a very basic shooter with a continuous enemy loop.</p>
<p>Was a good learning experience though, with the following take-aways:</p>
<p>1. I need to plan classes and inheritance before writing a single line of code. Going headfirst into coding is fine for something like pong, but any kind of complexity - even in a tiny demo for a basic scrolling shooter like this - needs a bit of thought, otherwise it becomes difficult to manage as the project grows.</p>
<p>2. I need to learn more about vector maths and basic trigonometry. I found myself copy/pasting lines for calculating rotation without fully understanding it, which I hate doing.</p>
<p>3.&nbsp; I need to understand inheritance better, though I think the frustrations around inheritance and polymorphism is related to the effects of point 1, not planning my classes enough (or at all).</p>
<p>4. I need to stick to a uniform style in regard to using public static/globals for convenience, or proper use of encapsulation and passing parameters. In this project I found myself getting lazy and just making anything and everything public. I think public static is fine for things that are reused continuously between classes, like SpriteBatch and ContentManager, and I think having a few Globals such as a game timer and screen width/height is fine, but everything else should be passed through. I'd really try like to try and maintain half-decent coding best practices as I learn C#.</p>
<p>5. I have zero clue about waypoints, what I have implemented here is a mess!</p>
<p>6. I need to do some reading up on design patterns and architectural principles.</p>
<p>So after this project I'm going to take a step back before heading into the next (probably a top-down shooter, like Cannon Fodder!), and do a bit more learning to figure out a few problems that this project threw up.</p>
