﻿namespace CodingInterview;

public class KthNodeFromEnd {
  public static ListNode? FindKthToTail(ListNode? head, uint k) {
    if (head is null || k == 0) {
      return null;
    }

    ListNode? ahead = head;

    for (int i = 0; i < k - 1; i++) {
      if (ahead.Next is not null) {
        ahead = ahead.Next;
      } else {
        return null;
      }
    }

    ListNode? behind = head;
    while (ahead.Next is not null) {
      ahead = ahead.Next;
      behind = behind?.Next;
    }

    return behind;
  }
}
