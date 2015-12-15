using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour {
	Vector3 _target;
	bool _usePatrol = true;
	public bool UsePatrol {
		get { 
			return _usePatrol;
		} set { 
			_usePatrol = value;
		}
	}

	void Update() {
		if (_usePatrol) {
			Patrol ();
		}
	}

	void Patrol() {
		if (_target == Vector3.zero) {
			_target = SetTarget ();
		} else {
			transform.position = Vector3.MoveTowards (transform.position, _target, 0.1f);
			if (transform.position == _target) {
				_target = SetTarget ();
			}
		}
	}

	Vector3 SetTarget() {
		float x = Random.Range(-8.0f,8.0f);
		float z = Random.Range(-5.0f,5.0f);
		return new Vector3 (x, 0, z);
	}
}
