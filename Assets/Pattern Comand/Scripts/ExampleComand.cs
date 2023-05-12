using Assets.Pattern_Comand.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExampleComand : MonoBehaviour
{
    [SerializeField] private Button buttonStepStraight;
    [SerializeField] private Button buttonStepDiagonal;
    [SerializeField] private Button buttonUndo;
    [SerializeField] private Transform pivotTransform;
    [SerializeField] private float steepDistance = 1f;

    private List<MoveComand> _moveJournal = new List<MoveComand>();

    private void OnEnable()
    {
        buttonStepStraight.onClick.AddListener(StepStraight);
        buttonStepDiagonal.onClick.AddListener(StepDiagonal);
        buttonUndo.onClick.AddListener(UndoLastMove);
    }

    private void OnDisable()
    {
        buttonStepStraight.onClick.RemoveListener(StepStraight);
        buttonStepDiagonal.onClick.RemoveListener(StepDiagonal);
        buttonUndo.onClick.RemoveListener(UndoLastMove);
    }

    private void StepStraight()
    {
        var move = new MoveStraight(pivotTransform, steepDistance);

        move.Execute();

        _moveJournal.Add(move);
        Debug.Log("Step Straight");
    }

    private void StepDiagonal()
    {
        var move = new MoveDiagonal(pivotTransform, steepDistance);

        move.Execute();

        _moveJournal.Add(move);
        Debug.Log("Step Diagonal");

    }

    private void UndoLastMove()
    {
        if (_moveJournal.Count > 0)
        {
            var lastMove = _moveJournal[_moveJournal.Count - 1];

            lastMove.Undo();
            _moveJournal.Remove(lastMove);
            Debug.Log("Undo Last Move");
        }
    }

}
