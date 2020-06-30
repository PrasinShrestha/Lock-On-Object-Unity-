# Lock-On-Object-Unity-
2 sets of codes that will return a GameObject as a lock-on target for any lock_on system 

1st File: Lock_OnBehaviour is to be attached to player GameObject.
2nd File: Lock_OnTarget is to be attached to enemies...or any possible target for lockon

This works by calling the 'LockTarget()' function in Lock_OnBehaviour. LockTarget() returns a GameObject closest to the player within the player's range of view.
The range of view is basically a collider(a trigger) in front of the player. 
The player's range can simply be altered by altering the size of the collider.
The enemies which also have a collider (not a trigger) within this range of player are possible 'Candidates'.
Each 'Candidates' distance to the player is tracked. The 'Candidate' closest to player is the 'target'
'target' is returned
